using System;
using System.Web.Script.Serialization;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EHI;

namespace JsonDemo
{
    public partial class GetEHIText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonString =js.Serialize(GetEHITextByChild(Request["EHIflare"]));
            Response.Write(jsonString);    
        }

        private object GetEHITextByChild(string name)
        {
            EHI.RootObject rObject = new EHI.RootObject();
            rObject.name = name;

            return rObject;
        }   
    }
}