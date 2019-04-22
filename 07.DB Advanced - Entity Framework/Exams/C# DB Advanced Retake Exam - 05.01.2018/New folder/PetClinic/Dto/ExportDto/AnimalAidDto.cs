using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PetClinic.Dto.ExportDto
{
    [XmlType("AnimalAid")]
    public class AnimalAidDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
