using CatAlog.Db.DbContexts;
using CatAlog.Db.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatAlog.GUI.ViewModels
{
    public class MainViewModel
    {
        CatalogRepository rep;

        public MainViewModel()
        {
            rep = new CatalogRepository();
            rep.GetAll();
        }
    }
}
