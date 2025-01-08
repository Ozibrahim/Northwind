using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Model
{
    public class AjaxResponse<T>
    {
        public bool result { get; set; }
        public T data { get; set; }
        public string mesaj { get; set; } = "";

        public AjaxResponse(bool result, T data, string mesaj="")
        {
            this.result = result;
            this.data = data;
            this.mesaj = mesaj;
        }
    }
}
