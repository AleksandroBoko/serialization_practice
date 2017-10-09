using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Practise.Domain;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Serialization_Practise.DataAccess
{
    class PupilDataAccess : IPupilDataAccess
    {
        public void SavePupils(List<Pupil> pupils)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Pupil>));

            using (FileStream fs = new FileStream("D://Pupils.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, pupils);
            }
        }

        public List<Pupil> GetPupils()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Pupil>));

            using (FileStream fs = new FileStream("D://Pupils.json", FileMode.OpenOrCreate))
            {
                return (List<Pupil>)jsonFormatter.ReadObject(fs);
            }
        }
    }
}
