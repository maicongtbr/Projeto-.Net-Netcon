using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Projeto_.NET_Netcon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class Converter : ControllerBase
    {
        [HttpGet(Name = "Convert")]
        public ReturnModel Get(float km, float anosLuz)
        {   
            float initialValue;
            double convertedValue;

            

            if (km > 1) //Valida��o e calculo da convers�o km > anos luz.
            {
                initialValue = (float)km;
                convertedValue = initialValue / 9460730472580.8;
            }
            else if (anosLuz > 1) //Valida��o e calculo da convers�o anos luz > km.
            {
                initialValue = (float)anosLuz;
                convertedValue = initialValue * 9460730472580.8;
            }
            else
            {
                ReturnModel errorModel = new()
                {
                    StatusCode = 400,
                    ErrorMessage = "invalid value",
                    DateTime = new DateTime()
                };

                return errorModel;
            }

            ReturnModel successModel = new()
            {
                StatusCode = 200,
                ErrorMessage = null,
                DateTime = DateTime.Now,
                value = convertedValue
            };

            return successModel;
        }
    }
}
