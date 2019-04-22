using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace PetClinic.Models
{
    public class Procedure
    {
        //-	Id – integer, Primary Key
        //-	AnimalId ¬– integer, foreign key
        //-	Animal – the animal on which the procedure is performed(required)
        //-	VetId ¬– integer, foreign key
        //-	Vet – the clinic’s employed doctor servicing the patient(required)
        //-	ProcedureAnimalAids – collection of type ProcedureAnimalAid
        //-	Cost – the cost of the procedure, calculated by summing the price of the different services performed; does not need to be inserted in the database
        //-	DateTime – the date and time on which the given procedure is performed(required)

        [Key]
        public int Id { get; set; }

        //[ForeignKey(nameof(Animal))]
        public int AnimalId { get; set; }
        [Required]
        public Animal Animal { get; set; }

        //[ForeignKey(nameof(Vet))]
        public int VetId { get; set; }
        [Required]
        public Vet Vet { get; set; }

        public ICollection<ProcedureAnimalAid> ProcedureAnimalAids { get; set; } = new List<ProcedureAnimalAid>();


        public decimal Cost => this.ProcedureAnimalAids.Sum(x => x.AnimalAid.Price);

        [Required]
        public DateTime DateTime { get; set; }
    }
}
