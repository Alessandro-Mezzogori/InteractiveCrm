namespace InteractiveCrm
{
    public class CodeInitializer
    {
        // TODO strategy pattern se si vuole piú template possibili
        public string GetInitialCode()
        {
            string code = @"using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;

class MainClass {
   public static void Main(IOrganizationService service){
      Console.WriteLine(""Hello World"");

      var request  = new WhoAmIRequest();
      var response = (WhoAmIResponse) service.Execute(request);
      Console.WriteLine(response.UserId);
   }
}";

            return code;
        }
    }
}