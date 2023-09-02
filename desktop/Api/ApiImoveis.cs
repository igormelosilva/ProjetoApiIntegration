using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using desktop.Models;

namespace desktop.Api
{
    public class ApiImoveis
    {
        public List<Imovel> GetAllImoveis()
        {
            List<Imovel> result = new List<Imovel>();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("Imovel/GetAll");

            result = JsonConvert.DeserializeObject<List<Imovel>>(response.data);

            return result;
        }

        public Imovel GetImovel(int id)
        {
            Imovel result = new Imovel();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("Imovel/Get?id=" + id);

            if (result != null && response.success)
            {
                result = JsonConvert.DeserializeObject<Imovel>(response.data);
            }

            return result;
        }

        public bool AddImovel(Imovel imovel)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(imovel);

            Result result = api.PostComand("Imovel/Add", parameters);

            return result.success;
        }

        public bool UpdateImovel(Imovel imovel)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(imovel);

            Result result = api.PutComand("Imovel/Update", parameters);

            return result.success;
        }

        public Result DeleteImovel(int id)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(id);

            Result result = api.DeleteComand("imovel/Delete?id=" + id);

            return result;
        }
    }
}
