using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaOSMVC.Models;

namespace SistemaOSMVC.Controllers
{
    public class OrdemServicoController : Controller
    {
        private dbSistemaOSEntities1 db = new dbSistemaOSEntities1();

        // GET: /OrdemServico/
        public ActionResult Index()
        {
            var ordemservico = db.OrdemServico.Include(o => o.AndamentoOS).Include(o => o.Cliente).Include(o => o.Defeito).Include(o => o.Equipamento).Include(o => o.Funcionario);
            return View(ordemservico.ToList());
        }

        // GET: /OrdemServico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdemServico ordemservico = db.OrdemServico.Find(id);
            if (ordemservico == null)
            {
                return HttpNotFound();
            }
            return View(ordemservico);
        }

        // GET: /OrdemServico/Create
        public ActionResult Create()
        {
            ViewBag.IdAndamentoOSFK = new SelectList(db.AndamentoOS, "IdAndamentoOS", "Nome");
            ViewBag.IdClienteFK = new SelectList(db.Cliente, "IdCliente", "Nome");
            ViewBag.IdDefeitoFK = new SelectList(db.Defeito, "IdDefeito", "Nome");
            ViewBag.IdEquipamentoFK = new SelectList(db.Equipamento, "IdEquipamento", "Acessorios");
            ViewBag.IdFuncionarioFK = new SelectList(db.Funcionario, "IdFuncionario", "Nome");
            return View();
        }

        // POST: /OrdemServico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="IdOrdemServico,IdClienteFK,IdFuncionarioFK,IdAndamentoOSFK,IdEquipamentoFK,IdDefeitoFK,OBSERVACAO")] OrdemServico ordemservico)
        {
            if (ModelState.IsValid)
            {
                db.OrdemServico.Add(ordemservico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAndamentoOSFK = new SelectList(db.AndamentoOS, "IdAndamentoOS", "Nome", ordemservico.IdAndamentoOSFK);
            ViewBag.IdClienteFK = new SelectList(db.Cliente, "IdCliente", "Nome", ordemservico.IdClienteFK);
            ViewBag.IdDefeitoFK = new SelectList(db.Defeito, "IdDefeito", "Nome", ordemservico.IdDefeitoFK);
            ViewBag.IdEquipamentoFK = new SelectList(db.Equipamento, "IdEquipamento", "Acessorios", ordemservico.IdEquipamentoFK);
            ViewBag.IdFuncionarioFK = new SelectList(db.Funcionario, "IdFuncionario", "Nome", ordemservico.IdFuncionarioFK);
            return View(ordemservico);
        }

        // GET: /OrdemServico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdemServico ordemservico = db.OrdemServico.Find(id);
            if (ordemservico == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAndamentoOSFK = new SelectList(db.AndamentoOS, "IdAndamentoOS", "Nome", ordemservico.IdAndamentoOSFK);
            ViewBag.IdClienteFK = new SelectList(db.Cliente, "IdCliente", "Nome", ordemservico.IdClienteFK);
            ViewBag.IdDefeitoFK = new SelectList(db.Defeito, "IdDefeito", "Nome", ordemservico.IdDefeitoFK);
            ViewBag.IdEquipamentoFK = new SelectList(db.Equipamento, "IdEquipamento", "Acessorios", ordemservico.IdEquipamentoFK);
            ViewBag.IdFuncionarioFK = new SelectList(db.Funcionario, "IdFuncionario", "Nome", ordemservico.IdFuncionarioFK);
            return View(ordemservico);
        }

        // POST: /OrdemServico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="IdOrdemServico,IdClienteFK,IdFuncionarioFK,IdAndamentoOSFK,IdEquipamentoFK,IdDefeitoFK,OBSERVACAO")] OrdemServico ordemservico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ordemservico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAndamentoOSFK = new SelectList(db.AndamentoOS, "IdAndamentoOS", "Nome", ordemservico.IdAndamentoOSFK);
            ViewBag.IdClienteFK = new SelectList(db.Cliente, "IdCliente", "Nome", ordemservico.IdClienteFK);
            ViewBag.IdDefeitoFK = new SelectList(db.Defeito, "IdDefeito", "Nome", ordemservico.IdDefeitoFK);
            ViewBag.IdEquipamentoFK = new SelectList(db.Equipamento, "IdEquipamento", "Acessorios", ordemservico.IdEquipamentoFK);
            ViewBag.IdFuncionarioFK = new SelectList(db.Funcionario, "IdFuncionario", "Nome", ordemservico.IdFuncionarioFK);
            return View(ordemservico);
        }

        // GET: /OrdemServico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdemServico ordemservico = db.OrdemServico.Find(id);
            if (ordemservico == null)
            {
                return HttpNotFound();
            }
            return View(ordemservico);
        }

        // POST: /OrdemServico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrdemServico ordemservico = db.OrdemServico.Find(id);
            db.OrdemServico.Remove(ordemservico);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
