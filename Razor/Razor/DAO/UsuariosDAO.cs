﻿using NHibernate;
using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razor.DAO
{
    public class UsuariosDAO
    {
        private ISession session;
        public UsuariosDAO(ISession session)
        {
            this.session = session;
        }


        public Usuario Login(string email, string senha)
        {
            var usuario = session.QueryOver<Usuario>();
            return usuario.Where(x => x.Email == email && x.Senha == senha).List().FirstOrDefault();   
        }

        public void Adiciona(Usuario usuario)
        {
            ITransaction transaction = session.BeginTransaction();
            session.Save(usuario);
            transaction.Commit();
        }

        public Usuario Find(int Id)
        {
            return session.Get<Usuario>(Id);
        }
    }
}