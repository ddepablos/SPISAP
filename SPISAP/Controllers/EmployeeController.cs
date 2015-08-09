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
            List<DPERSONALES> records = EmployeeRep.Find(); //.FindByCedula("11681109");
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

                // agregar los valores por defecto.
                //EmployeeModel.COD_PAIS = "VE";
                //EmployeeModel.FRM1_CT_COD_CLASE = EmployeeModel.FRM1_COD_CLASE;
                //EmployeeModel.FRM1_CE_COD_CLASE = EmployeeModel.FRM1_COD_CLASE;

                //EmployeeModel.FRM2_CT_COD_CLASE = EmployeeModel.FRM2_COD_CLASE;
                //EmployeeModel.FRM2_CE_COD_CLASE = EmployeeModel.FRM2_COD_CLASE;

                //EmployeeModel.FRM3_CT_COD_CLASE = EmployeeModel.FRM3_COD_CLASE;
                //EmployeeModel.FRM3_CE_COD_CLASE = EmployeeModel.FRM3_COD_CLASE;

                if (ModelState.IsValid)
                {

                    // validación del modelo.
                    EmployeeRepository e = new EmployeeRepository(EmployeeModel);

                    e.AddNew();

                    return RedirectToAction("Index");

                }

                return View(EmployeeModel);

            }
            catch( Exception e )
            {
                Console.Write(e);
                return View();
            }
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id)
        {
            EmployeeViewModel model = EmployeeRep.FindEmployee(id.ToString());

            return View(model);
        }

        //
        // POST: /Employee/Edit/5
        [HttpPost]
        public ActionResult Edit( EmployeeViewModel EmployeeModel ) // (int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                //if (ModelState.IsValid)
                //{

                    // validación del modelo.
                    EmployeeRepository e = new EmployeeRepository(EmployeeModel);

                    if ( e.Update() )
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(EmployeeModel);
                    }


                //}

                //return View(EmployeeModel);

                //return RedirectToAction("Index");
            }
            catch( Exception e )
            {
                Console.Write(e.Message);
                return View(EmployeeModel);
            }
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
            //List<GenericModel> records = ListViewModel.GetTallaChemise();
            List<Generic2Model> records = ListViewModel.GetTallaChemise();

            //return Json(new SelectList(records.Where(x => x.CODIGO == id), "CODIGO", "DESCRIPCION"), JsonRequestBehavior.AllowGet);
            return Json(new SelectList(records.Where(x => x.FOREINGKEY == id), "CODIGO", "DESCRIPCION"), JsonRequestBehavior.AllowGet);
        }

        // retornar JSON : Talla de Pantalón.
        public JsonResult GetPantalonList(string id)
        {
            List<Generic2Model> records = ListViewModel.GetTallaPantalon();

            return Json(new SelectList(records.Where(x => x.FOREINGKEY == id), "CODIGO", "DESCRIPCION"), JsonRequestBehavior.AllowGet);
        }

        // retornar JSON : Talla de Calzado.
        public JsonResult GetCalzadoList(string id)
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
