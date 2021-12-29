﻿using Microsoft.AspNet.Identity;
using SRMDataManagerLibrary.DataAccess;
using SRMDataManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SahilCoRetailManager.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        // GET api/values
        public List<ProductModel> Get()
        {
            ProductData data = new ProductData();

            return data.GetProducts();
        }

    }
}
