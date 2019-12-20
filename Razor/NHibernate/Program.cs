using DAL.Infra;
using NHibernate.Cfg;
using Pesistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pesistencia.DAO;
using NHibernate.Linq;

namespace NHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            NHibernateHelper.GeraSchema();
            Configuration cfg = NHibernateHelper.RecuperaConfiguracao();

            ISessionFactory sessionFactory = cfg.BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            Usuario usuario = new Usuario();
            usuario.Nome = "Mariana";

            ITransaction transacao = session.BeginTransaction();
            session.Save(usuario);
            transacao.Commit();

            session.Close();
            */

            ISession session = NHibernateHelper.OpenSession();
            /*
            UsuarioDAO usuarioDao = new UsuarioDAO(session);

            Usuario usuario = new Usuario();
            usuario.Nome = "Michelle";

            usuarioDao.Add(usuario);
            */
            //IQuery query = session.CreateQuery("FROM Usuario");
            //var vaListaUsuario = query.List<Usuario>();
            var vaListaUsuario = session.QueryOver<Usuario>().List();
            

            session.Close();

            Console.Read();
        }
    }
}
