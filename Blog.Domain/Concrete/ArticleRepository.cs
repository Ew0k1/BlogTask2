﻿using Blog.Domain.Abstract;
using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Concrete
{
    public class ArticleRepository : IRepository<Article>
    {
        private BlogContext db;

        public ArticleRepository(BlogContext context)
        {
            db = context;
        }

        public void Create(Article item)
        {
            db.Articles.Add(item);
        }

        public void Delete(int id)
        {
            Article item = db.Articles.Find(id);
            if (item != null)
                db.Articles.Remove(item);
        }

        public Article Find(int id)
        {
            return db.Articles.Find(id);
        }

        public IEnumerable<Article> FindAll()
        {
            return db.Articles;
        }

        public void Update(Article item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
