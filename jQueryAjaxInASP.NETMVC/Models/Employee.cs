//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jQueryAjaxInASP.NETMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public Nullable<int> Salary { get; set; }

        [DisplayName("Image")]
        public string ImagePath { get; set; }

        /*
         Inorder to work with files in ASP.NET MVC Application we will use #HttpPostedFileBase
         So, Add  public HttpPostedFileBase ImageUpload { get; set; } Property 
         And:: using System.Web;
         */

        /*
            Now, We need to Add #NotMapped Property Because this property is not inside our Table Employee 
        Add:: using System.ComponentModel.DataAnnotations.Schema;
        */

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        /*
            Inorder to Save Uploaded Images, Add a Folder inside Project
            Add NewFOlder=> AppFiles => NewFolder=> Image
            And Add Default Image in Image Folder
        */

        public Employee()
        {
            ImagePath = "~/AppFiles/Images/default.png";
        }
    }
}
