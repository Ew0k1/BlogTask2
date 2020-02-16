using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Concrete
{
    public class UnitOfWork : IDisposable
    {
        private BlogContext db = new BlogContext();
        private ArticleRepository articleRepository;
        private ReviewRepository reviewrRepository;
        private RoleRepository roleRepository;
        private bool disposed = false;

        public ArticleRepository Articles
        {
            get
            {
                if (articleRepository == null)
                    articleRepository = new ArticleRepository(db);
                return articleRepository;
            }
        }

        public ReviewRepository Reviews
        {
            get
            {
                if (reviewrRepository == null)
                    reviewrRepository = new ReviewRepository(db);
                return reviewrRepository;
            }
        }

        public RoleRepository Roles
        {
            get
            {
                if (roleRepository == null)
                    roleRepository = new RoleRepository(db);
                return roleRepository;

            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
