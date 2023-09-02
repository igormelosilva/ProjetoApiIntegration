using api.Database;
using api.Global;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [ApiController]
    [Route("api/Imovel")]
    public class ImovelController : Controller
    {
        [HttpGet]
        [Route("GetAll")]


        public Result GetAll()
        {
            Result result = new Result();
            try
            {
                List<Imovel> listaImovel = new List<Imovel>();
                DbImovel dbImovel = new DbImovel();
                listaImovel = dbImovel.GetAll();

                if (listaImovel.Count > 0)
                {
                    result.success = true;
                    result.data = JsonConvert.SerializeObject(listaImovel);

                }
                else
                {
                    result.errorCode = Convert.ToInt32(ErrorCode.ImovelNotFoundError);
                    result.errorMessage = ErrorCode.ImovelNotFoundError.ToString();
                }

            }
            catch (Exception ex)
            {
                result.errorCode = Convert.ToInt32(ErrorCode.UnknownError);
                result.errorMessage = ErrorCode.UnknownError.ToString() + " - " + ex.Message;
            }
            return result;
        }

        [HttpGet]
        [Route("Get")]

        public Result Get(int id)
        {
            Result result = new Result();

            try
            {
                Imovel imovel = new Imovel();
                DbImovel dbImovel = new DbImovel();
                imovel = dbImovel.Get(id);

                result.success = true;
                result.data = JsonConvert.SerializeObject(imovel);

            }
            catch (Exception ex)
            {
                result.errorCode = Convert.ToInt32(ErrorCode.UnknownError);
                result.errorMessage = ErrorCode.UnknownError.ToString() + " - " + ex.Message;
            }

            return result;
        }

        [HttpPost]
        [Route("Add")]

        public Result Add(Imovel imovel)
        {
            Result result = new Result();
            try
            {
                DbImovel dbImovel = new DbImovel();
                bool response = dbImovel.Add(imovel);
                if (response)
                {
                    result.success = true;

                }
                else
                {
                    result.errorCode = Convert.ToInt32(ErrorCode.ImovelNotFoundError);
                    result.errorMessage = ErrorCode.ImovelNotFoundError.ToString();
                }

            }
            catch (Exception ex)
            {
                result.errorCode = Convert.ToInt32(ErrorCode.UnknownError);
                result.errorMessage = ErrorCode.UnknownError.ToString() + " - " + ex.Message;
            }
            return result;
        }


        [HttpPut]
        [Route("Update")]
        public Result Update(Imovel imovel)
        {
            Result result = new Result();

            try
            {
                DbImovel dbImovel = new DbImovel();
                bool response = dbImovel.Update(imovel);

                if (response)
                {
                    result.success = true;

                }
                else
                {
                    result.errorCode = Convert.ToInt32(ErrorCode.ImovelNotFoundError);
                    result.errorMessage = ErrorCode.ImovelNotFoundError.ToString();
                }

            }
            catch (Exception ex)
            {
                result.errorCode = Convert.ToInt32(ErrorCode.UnknownError);
                result.errorMessage = ErrorCode.UnknownError.ToString() + " - " + ex.Message;
            }

            return result;
        }

        [HttpDelete]
        [Route("Delete")]


        public Result Delete(string id)
        {

            Result result = new Result();
            try
            {
                
                DbImovel dbImovel = new DbImovel();
                bool response = dbImovel.Delete(id);
                if (response)
                {
                    result.success = true;
                }
                else
                {
                    result.errorCode = Convert.ToInt32(ErrorCode.ImovelNotFoundError);
                    result.errorMessage = ErrorCode.ImovelNotFoundError.ToString();
                }
            }


            catch (Exception ex)
            {
                result.errorCode = Convert.ToInt32(ErrorCode.UnknownError);
                result.errorMessage = ErrorCode.UnknownError.ToString() + " - " + ex.Message;
            }
            return result;
        }   
    }
}
