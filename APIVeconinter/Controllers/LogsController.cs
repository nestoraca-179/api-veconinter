using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIVeconinter.Models;

namespace APIVeconinter.Controllers
{
    public class LogsController
    {
        public static int CreateLog(string num_bl, string num_solv, DateTime fec_hasta, bool pendiente)
        {
            int result;

            Logs log = new Logs
            {
                Fecha = DateTime.Now,
                NumBL = num_bl,
                NumSolvencia = num_solv,
                FechaHasta = fec_hasta,
                Pendiente = pendiente
            };

            using (APIVeconinterEntities context = new APIVeconinterEntities())
            {
                Logs new_log = context.Logs.Add(log);
                context.SaveChanges();

                result = new_log.ID;
            }

            return result;
        }

        public static void CreateIncident(string titulo, Exception ex)
        {
            Incidents error = new Incidents();

            error.Titulo = titulo;
            error.Descripcion = ex != null ? string.Format("{0} -> {1} -> {2}", ex.Message, ex.StackTrace, ex.Source) : "N/A";
            error.Fecha = DateTime.Now;

            using (APIVeconinterEntities context = new APIVeconinterEntities())
            {
                context.Incidents.Add(error);
                context.SaveChanges();
            }
        }
    }
}