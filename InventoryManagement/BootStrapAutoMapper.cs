using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataModel = InventoryManagement.Data;
using UiModel = InventoryManagement.Model.Models;

namespace InventoryManagement
{
    public class BootstrapAutoMapper
    {
        public static void InitializeAutoMapper()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<UiModel.Company, DataModel.Company>();
            });
        }
    }
}