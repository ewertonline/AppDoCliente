﻿using MTC.AppDoCliente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTC.AppDoCliente.ViewModels
{
    public class BaseViewModel
    {
        /// <summary>
        /// Get the azure service instance
        /// </summary>
        public FunilariaService DadosFunilaria = new FunilariaService();

        //bool isBusy = false;
        //public bool IsBusy
        //{
        //    get { return isBusy; }
        //    set { SetProperty(ref isBusy, value); }
        //}
        /// <summary>
        /// Private backing field to hold the title
        /// </summary>
        //string title = string.Empty;
        ///// <summary>
        ///// Public property to set and get the title of the item
        ///// </summary>
        //public string Title
        //{
        //    get { return title; }
        //    set { SetProperty(ref title, value); }
        //}
    }
}
