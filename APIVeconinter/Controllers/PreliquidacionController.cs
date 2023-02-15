using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using APIVeconinter.Models;

namespace APIVeconinter.Controllers
{
    public class PreliquidacionController : ApiController
    {
        [HttpPost]
        [Route("api/Preliquidacion/RegistrarSolvencia/")]
        public int RegistrarSolvencia(Solvency solvency)
        {
            int result;

            int dia = int.Parse(solvency.fec_hasta.Split('-')[0]);
            int mes = int.Parse(solvency.fec_hasta.Split('-')[1]);
            int anio = int.Parse(solvency.fec_hasta.Split('-')[2]);

            DateTime fecha = new DateTime(anio, mes, dia);

            using (ATLANTISEntities db = new ATLANTISEntities())
            {
                using (DbContextTransaction tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        BLEmbarque bl = db.BLEmbarque.AsNoTracking().SingleOrDefault(b => b.NroBLEmbarque == solvency.nro_bl);

                        if (bl != null)
                        {
                            List<string> conts_sent = solvency.conts.Split(',').ToList();
                            List<string> conts_save = (
                                from ic in db.ItinerarioContenedor.AsNoTracking()
                                join c in db.Contenedor.AsNoTracking() on ic.IdContenedor equals c.IdContenedor
                                where ic.BLContenedor == solvency.nro_bl
                                select c.SiglasContenedor
                            ).ToList();

                            if (conts_sent.Count == conts_save.Count)
                            {
                                conts_sent.Sort();
                                conts_save.Sort();

                                if (string.Join(",", conts_sent) == string.Join(",", conts_save))
                                {
                                    Preliquidacion preq = db.Preliquidacion.AsNoTracking().SingleOrDefault(p =>
                                        p.BLPreliquidacion == bl.IdBLEmbarque &&
                                        p.EstatusPreliquidacion != 4 &&
                                        p.EmpresaPreliquidacion == 2
                                    );

                                    if (preq != null)
                                    {
                                        preq.SolventePreliquidacion = true;
                                        preq.NroSolvenciaPreliquidacion = solvency.nro_solv;
                                        preq.FechaHastaSolvenciaPreliquidacion = fecha;

                                        db.Entry(preq).State = EntityState.Modified;
                                        db.SaveChanges();
                                        tran.Commit();

                                        result = LogsController.CreateLog(solvency.nro_bl, solvency.nro_solv, fecha, false); // preq.NroPreliquidacion;
                                    }
                                    else
                                    {
                                        result = -4; // BL SIN PRELIQUIDAR
                                        LogsController.CreateLog(solvency.nro_bl, solvency.nro_solv, fecha, true);
                                        LogsController.CreateIncident("BL " + solvency.nro_bl + " SIN PRELIQUIDAR", null);
                                    }
                                }
                                else
                                {
                                    result = -3; // CONTENEDORES NO COINCIDEN
                                    LogsController.CreateIncident(string.Format(
                                        "CONTENEDORES ENVIADOS ({0}) NO COINCIDEN CON LOS REGISTRADOS EN EL BL ({1})",
                                        string.Join(",", conts_sent), string.Join(",", conts_save)
                                    ), null);
                                }
                            }
                            else
                            {
                                result = -2; // NUMERO DE CONTENEDORES NO COINCIDEN
                                LogsController.CreateIncident(string.Format(
                                    "NUMERO DE CONTENEDORES ENVIADOS ({0}) NO COINCIDEN CON LOS REGISTRADOS EN EL BL ({1})", conts_sent.Count, conts_save.Count
                                ), null);
                            }
                        }
                        else
                        {
                            result = -1; // BL NO ENCONTRADO
                            LogsController.CreateIncident("BL " + solvency.nro_bl + " NO ENCONTRADO", null);
                        }
                    }
                    catch (Exception ex)
                    {
                        result = 0; // ERROR GENERAL
                        tran.Rollback();
                        LogsController.CreateIncident(string.Format("ERROR GENERAL AGREGANDO DATOS DE SOLVENCIA ({0}, {1}, {2})", solvency.nro_bl, solvency.nro_solv, solvency.fec_hasta), ex);
                    }
                }
            }

            return result;
        }
    }
}