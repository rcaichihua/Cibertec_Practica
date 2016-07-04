﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CategorieData :BaseDataAccess<Categorie>
    {
        public Categorie GetCategorie(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.categorie.FirstOrDefault(x => x.CategoryID == id);
            }
        }
    }
}
