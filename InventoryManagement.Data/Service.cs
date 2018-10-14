using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Data;

namespace InventoryManagement.Data
{
    public class Service
    {
        InventoryManagementEntities InventoryManagementEntities;

        public Service()
        {
            this.InventoryManagementEntities = new InventoryManagementEntities();
        }

        public void AddCompany(Company company)
        {
            this.InventoryManagementEntities.Companies.Add(company);
        }
    }
}