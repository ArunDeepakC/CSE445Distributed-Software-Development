using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

/// CONTRIBUTION:
/// Name:   Rishti Gupta
/// ASUID:  1217211814
/// Email:  rgupta75@asu.edu
/// Class:  CSE-445 (#96279)

///AND

/// Name:   Arun Deepak Chandrasekar
/// ASUID:  1217200647
/// Email:  achand66@asu.edu
/// Class:  CSE-445 (#96279)

namespace Project2_CSE445
{
    class Encoder
    {
        // Encode the OrderClass into a string using XmlSerializer.
        // Returns the order object stored by travel agency in the form of a string
        public static string EncodeOrder(OrderClass order)
        {
            XmlSerializer serializer = new XmlSerializer(order.GetType());

            using (StringWriter sw = new StringWriter())
            {
                serializer.Serialize(sw, order);
                return sw.ToString();
            }
        }
    }
}
