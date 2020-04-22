using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pesistencia.Entidades;
using DAL.Infra;

namespace Pesistencia.DAO
{
    public class UsuarioDAO
    {

        private ISession session;

        public UsuarioDAO(ISession session)
        {
            this.session = session;
        }

        public void Add(Usuario usuario)
        {
            ITransaction transaction = session.BeginTransaction();
            session.Save(usuario);
            transaction.Commit();
        }

        public Usuario Find (int Id)
        {
            return session.Get<Usuario>(Id);
        }

        


    }
}
