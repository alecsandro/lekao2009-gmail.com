using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ProjetoMicropost_DLL.Homologacao;
using System.ServiceModel;

namespace ProjetoMicropost_DLL
{
    public class ClasseMetodos
        
    {
        //ws prod producao
        public ProjetoMicropost_DLL.serviceMicropost.Service1SoapClient wsProd;


        //webservice de homologacao
        public ProjetoMicropost_DLL.Homologacao.Service1SoapClient wsHomo;

        public ClasseMetodos()
        {

            //no de producao terems que trocar essa URL abaixo....
            EndpointAddress endereco = new EndpointAddress("http://homologacao.prepostagem.com.br/MpWebService.asmx?wsdl");
            BasicHttpBinding Tbinding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            Tbinding.MaxBufferSize = 64000000;
            Tbinding.MaxReceivedMessageSize = 64000000;

            wsHomo = new Homologacao.Service1SoapClient(Tbinding, endereco);
        }
        
        public string SerializarObjeto(Object objeto)
        {
            string xml = "";

            XmlSerializer xmlSerializer = new XmlSerializer(objeto.GetType());
            using (StringWriter texto = new StringWriter())
            {
                xmlSerializer.Serialize(texto, objeto);
                xml = texto.ToString();
            }

            return xml;
        }

        public string RetornaTeste(string cep = "13060705", string user = "HomologacaoMP", string pass = "Dej6PFEcPiNGyHm1JK")
        {
            Homologacao.EnderecoMp endere = new Homologacao.EnderecoMp();
            endere = wsHomo.RetornaEndereco( cep,  user, pass);

            string ObjetoSerializado = this.SerializarObjeto(endere);

            return ObjetoSerializado;
        }


        



    }
}
