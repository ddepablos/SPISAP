using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPISAP.Repositories;
using SPISAP.Models;
using System.Globalization;

namespace SPISAP.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        EmployeeRepository EmployeeRep = new EmployeeRepository();

        public ActionResult Index()
        {
            EmployeeViewModel record = EmployeeRep.GetEmployee();
            return View();
        }

        public ActionResult Table()
        {
            if (@Session["USUARIO"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            List<DPERSONALES> records = EmployeeRep.Find(); 
            return View(records);
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            if (@Session["USUARIO"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            EmployeeViewModel employee = new EmployeeViewModel();
            return View("Create", employee);
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult Create(EmployeeViewModel EmployeeModel)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    EmployeeRepository e = new EmployeeRepository(EmployeeModel);

                    // validación del modelo.
                    if (e.IsCedulaAlert())
                    {
                        ModelState.AddModelError("Cédula Duplicada", "Cédula Duplicada : Existe un Trabajador con el mismo valor : " + EmployeeModel.CEDULA );
                    }
                    else if (e.IsFichaAlert())
                    {
                        ModelState.AddModelError("Ficha Duplicada", "Ficha Duplicada : Existe un Trabajador con el mismo valor : " + EmployeeModel.FICHA);
                    }
                    else if ( ! e.IsEdadValid() )
                    {
                        ModelState.AddModelError("Menor de Edad", "Fecha de Nacimiento : La edad debe ser mayor/igual a 16 años.");
                    }
                    else if (! e.IsFamiliar2Valid())
                    {
                        ModelState.AddModelError("Familar # 2", "Familar # 2 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar3Valid())
                    {
                        ModelState.AddModelError("Familar # 3", "Familar # 3 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar4Valid())
                    {
                        ModelState.AddModelError("Familar # 4", "Familar # 4 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar5Valid())
                    {
                        ModelState.AddModelError("Familar # 5", "Familar # 5 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar6Valid())
                    {
                        ModelState.AddModelError("Familar # 6", "Familar # 6 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar7Valid())
                    {
                        ModelState.AddModelError("Familar # 7", "Familar # 7 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar8Valid())
                    {
                        ModelState.AddModelError("Familar # 8", "Familar # 8 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar9Valid())
                    {
                        ModelState.AddModelError("Familar # 9", "Familar # 9 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar10Valid())
                    {
                        ModelState.AddModelError("Familar # 10", "Familar # 10 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.FRM1_FECHA_INICIO, EmployeeModel.FRM1_FECHA_FIN))
                    {
                        ModelState.AddModelError("F1F", "Formación # 1 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsFormacion2Alert())
                    {
                        ModelState.AddModelError("F2", "Formación # 2 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.FRM2_FECHA_INICIO, EmployeeModel.FRM2_FECHA_FIN))
                    {
                        ModelState.AddModelError("F2F", "Formación # 2 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsFormacion3Alert())
                    {
                        ModelState.AddModelError("F3", "Formación # 3 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.FRM2_FECHA_INICIO, EmployeeModel.FRM2_FECHA_FIN))
                    {
                        ModelState.AddModelError("F3F", "Formación # 3 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsExperiencia1Alert())
                    {
                        ModelState.AddModelError("E1", "Experiencia Laboral # 1 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.EXP1_FECHA_INICIO, EmployeeModel.EXP1_FECHA_FIN))
                    {
                        ModelState.AddModelError("E1F", "Experiencia Laboral # 1 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsExperiencia2Alert())
                    {
                        ModelState.AddModelError("E2", "Experiencia Laboral # 2 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.EXP2_FECHA_INICIO, EmployeeModel.EXP2_FECHA_FIN))
                    {
                        ModelState.AddModelError("E2F", "Experiencia Laboral # 2 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsExperiencia3Alert())
                    {
                        ModelState.AddModelError("E3", "Experiencia Laboral # 3 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.EXP3_FECHA_INICIO, EmployeeModel.EXP3_FECHA_FIN))
                    {
                        ModelState.AddModelError("E3F", "Experiencia Laboral # 3 : El rango de fechas no es válido.");
                    }
                    else if (HttpContext.ApplicationInstance.Session["COD_USER"] == null)
                    {
                        ModelState.AddModelError("Experiencia Laboral", "Sesión Usuario : Su sesión ha caducado, debe ingresar nuevamente.");
                    }
                    else
                    {
                        if (e.AddNew())
                        {
                            return RedirectToAction("Filter", "Employee");
                        }
                    }

                }

                EmployeeModel.ERROR = (string) HttpContext.ApplicationInstance.Session["ERROR"];
                return View(EmployeeModel);

            }
            catch( Exception e )
            {
                HttpContext.ApplicationInstance.Session["ERROR"] = e.InnerException.InnerException.Message;
                return View(EmployeeModel);
            }
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int? id)
        {
            
            if (@Session["USUARIO"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            if (id == null)
            {
                EmployeeViewModel model = (EmployeeViewModel)TempData["ConfirmacionModel"];
                TempData["ConfirmacionModel"] = null;
                return View(model);
            }
            else
            {
                EmployeeViewModel model = EmployeeRep.FindEmployee(id.ToString());
                return View(model);
            }
           
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( EmployeeViewModel EmployeeModel )
        {
            try
            {

                if (ModelState.IsValid)
                {

                    EmployeeRepository e = new EmployeeRepository(EmployeeModel);

                    // validación del modelo.
                    if (!e.IsEdadValid())
                    {
                        ModelState.AddModelError("Menor de Edad", "Fecha de Nacimiento : La edad debe ser mayor/igual a 16 años.");
                    }
                    else if (!e.IsFamiliar2Valid())
                    {
                        ModelState.AddModelError("Familar # 2", "Familar # 2 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar3Valid())
                    {
                        ModelState.AddModelError("Familar # 3", "Familar # 3 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar4Valid())
                    {
                        ModelState.AddModelError("Familar # 4", "Familar # 4 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar5Valid())
                    {
                        ModelState.AddModelError("Familar # 5", "Familar # 5 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar6Valid())
                    {
                        ModelState.AddModelError("Familar # 6", "Familar # 6 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar7Valid())
                    {
                        ModelState.AddModelError("Familar # 7", "Familar # 7 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar8Valid())
                    {
                        ModelState.AddModelError("Familar # 8", "Familar # 8 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar9Valid())
                    {
                        ModelState.AddModelError("Familar # 9", "Familar # 9 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsFamiliar10Valid())
                    {
                        ModelState.AddModelError("Familar # 10", "Familar # 10 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.FRM1_FECHA_INICIO, EmployeeModel.FRM1_FECHA_FIN))
                    {
                        ModelState.AddModelError("F1F", "Formación # 1 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsFormacion2Alert())
                    {
                        ModelState.AddModelError("F2", "Formación # 2 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.FRM2_FECHA_INICIO, EmployeeModel.FRM2_FECHA_FIN))
                    {
                        ModelState.AddModelError("F2F", "Formación # 2 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsFormacion3Alert())
                    {
                        ModelState.AddModelError("F3", "Formación # 3 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.FRM2_FECHA_INICIO, EmployeeModel.FRM2_FECHA_FIN))
                    {
                        ModelState.AddModelError("F3F", "Formación # 3 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsExperiencia1Alert())
                    {
                        ModelState.AddModelError("E1", "Experiencia Laboral # 1 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.EXP1_FECHA_INICIO, EmployeeModel.EXP1_FECHA_FIN))
                    {
                        ModelState.AddModelError("E1F", "Experiencia Laboral # 1 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsExperiencia2Alert())
                    {
                        ModelState.AddModelError("E2", "Experiencia Laboral # 2 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.EXP2_FECHA_INICIO, EmployeeModel.EXP2_FECHA_FIN))
                    {
                        ModelState.AddModelError("E2F", "Experiencia Laboral # 2 : El rango de fechas no es válido.");
                    }
                    else if (!e.IsExperiencia3Alert())
                    {
                        ModelState.AddModelError("E3", "Experiencia Laboral # 3 : Los campos no están llenados completamente.");
                    }
                    else if (!e.IsRangeValid(EmployeeModel.EXP3_FECHA_INICIO, EmployeeModel.EXP3_FECHA_FIN))
                    {
                        ModelState.AddModelError("E3F", "Experiencia Laboral # 3 : El rango de fechas no es válido.");
                    }
                    else if (HttpContext.ApplicationInstance.Session["COD_USER"] == null)
                    {
                        ModelState.AddModelError("Experiencia Laboral", "Sesión Usuario : Su sesión ha caducado, debe ingresar nuevamente.");
                    }
                    else
                    {
                        // cargar el modelo temporal para la confirmación.
                        TempData["ConfirmacionModel"] = EmployeeModel;
                        return RedirectToAction("Confirm");
                    }

                }

                return View(EmployeeModel);

            }
            catch( Exception e )
            {
                Console.Write(e.Message);
                return View(EmployeeModel);
            }
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Confirm()
        {
            if (@Session["USUARIO"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            EmployeeViewModel confirmacion = (EmployeeViewModel) TempData["ConfirmacionModel"];

            TempData.Keep("ConfirmacionModel");
            return View(confirmacion);
        }

        //
        // POST: /Employee/Confirm/5

        [HttpPost]
        public ActionResult Confirm(EmployeeViewModel EmployeeModel)
        {

            // PARCHE_LEÓN
            EmployeeViewModel modelo = (EmployeeViewModel)TempData["ConfirmacionModel"];

            TempData["ConfirmacionModel"] = null;

            if (modelo.CEDULA == null)
            {
                // redireccionar a la vista inicial de pago en línea.
                return RedirectToAction("Index","Home");
            }
            else
            {
                // actualizar el registro del trabajador.
                EmployeeRepository e = new EmployeeRepository(modelo);

                if (e.Update())
                {
                    return RedirectToAction("Filter", "Employee");
                    //return RedirectToAction("Registrado");
                }
                else
                {
                    return RedirectToAction("Edit", modelo);
                    //return RedirectToAction("Rechazado");
                }

            }

        }

        //
        // /Employee/Filter

        public ActionResult Filter()
        {
            if (@Session["USUARIO"] == null)
	        {
                return RedirectToAction("Login", "Home");
	        }
            return View();
        }

        //
        // POST: /Employee/Filter/5

        [HttpPost]
        public ActionResult Filter(FilterViewModel filter)
        {

            // TODO: Add delete logic here
            if (ModelState.IsValid)
            {

                if (filter.CEDULA == null && filter.FICHA == null && filter.PRIMER_APELLIDO == null)
                {
                    ModelState.AddModelError("Filtro", "Es requerido ingresar un valor para ejecutar la búsqueda.");
                }
                else
                {
                    EmployeeRepository rep = new EmployeeRepository();

                    List<DPERSONALES> personales = null;

                    if (filter.CEDULA != null)
                    {
                        //records = db.DPERSONALES.Where(x => x.CEDULA.Equals(filter.CEDULA)).ToList();
                        personales = rep.FindByCedula(filter.CEDULA);
                    }
                    if (filter.FICHA != null)
                    {
                        //records = db.DPERSONALES.Where(x => x.FICHA.Equals(filter.FICHA)).ToList();
                        personales = rep.FindByFicha(filter.FICHA);
                    }
                    if (filter.PRIMER_APELLIDO != null)
                    {
                        personales = rep.FindByLastName(filter.PRIMER_APELLIDO);
                    }

                    return View("Table", personales);
                }

                return View(filter);

            }
            else
            {

                return View(filter);
           
            }

        }

        #region JSONRESULT

        // :: DATOS_PERSONALES :: //

        // retornar JSON : Nacionalidades
        public JsonResult GetNacionalidadList(string id)
        {
            List<NACIONALIDAD> records = ListViewModel.Nacionalidades();
            return Json(new SelectList(records.Where(x => x.COD_NACIONALIDAD == id), "COD_NACIONALIDAD", "DES_NACIONALIDAD"), JsonRequestBehavior.AllowGet);
        }

        // retornar JSON : Estado de Nacimiento.
        public JsonResult GetEstadoList(string id)
        {
            List<PAIS_ESTADO> records = ListViewModel.GetPaisEstados();
            return Json(new SelectList(records.Where(x => x.COD_PAIS == id), "COD_ESTADO", "DES_ESTADO"), JsonRequestBehavior.AllowGet);
        }

        // retornar JSON : Talla de Camisa.
        public JsonResult GetChemiseList(string id)
        {
            List<Generic2Model> records = ListViewModel.GetTallaChemise();
            return Json(new SelectList(records.Where(x => x.FOREINGKEY == id), "CODIGO", "DESCRIPCION"), JsonRequestBehavior.AllowGet);
        }

        // retornar JSON : Talla de Pantalón.
        public JsonResult GetPantalonList(string id)
        {
            List<Generic2Model> records = ListViewModel.GetTallaPantalon();
            return Json(new SelectList(records.Where(x => x.FOREINGKEY == id), "CODIGO", "DESCRIPCION"), JsonRequestBehavior.AllowGet);
        }

        // retornar JSON : Talla de Calzado.
        public JsonResult GetCalzadoList() //string id)
        {
            List<GenericModel> records = ListViewModel.GetTallaCalzado();
            return Json(new SelectList(records.Where(x => x.CODIGO != " "), "CODIGO", "DESCRIPCION"), JsonRequestBehavior.AllowGet);
        }

        // :: DATOS_DE_DIRECCIÓN :: //

        // retornar JSON : Municipios
        public JsonResult GetMunicipioList(string id)
        {
            List<MUNICIPIO_SSO> records = ListViewModel.GetMunicipioSSO();
            return Json(new SelectList(records.Where(x => x.COD_ESTADO_SSO == id), "COD_MUNICIPIO", "DES_MUNICIPIO"), JsonRequestBehavior.AllowGet);
        }

        // retornar JSON : Parroquias
        public JsonResult GetParroquiaList(string id)
        {
            List<PARROQUIA_SSO> records = ListViewModel.GetParroquiaSSO();
            return Json(new SelectList(records.Where(x => x.COD_MUNICIPIO == id), "COD_PARROQUIA", "DES_PARROQUIA"), JsonRequestBehavior.AllowGet);
        }

        // :: DATOS_DE_FORMACIÓN :: //

        // retornar JSON : CLASE_INSTITUTO / Condición
        public JsonResult GetCondicionList(string id)
        {
            List<CLASE_TITULO> records = ListViewModel.GetCondiciones();
            return Json(new SelectList(records.Where(x => x.COD_CLASE == id), "COD_TITULO", "DES_TITULO"), JsonRequestBehavior.AllowGet);
        }

        // retornar JSON : CLASE_ESPECIALIDAD / Especialidad
        public JsonResult GetEspecialidadList(string id)
        {
            List<CLASE_ESPECIALIDAD> records = ListViewModel.GetEspecialidades();
            return Json(new SelectList(records.Where(x => x.COD_CLASE == id), "COD_ESPECIALIDAD", "DES_ESPECIALIDAD"), JsonRequestBehavior.AllowGet);
        }

        #endregion



    }
}
