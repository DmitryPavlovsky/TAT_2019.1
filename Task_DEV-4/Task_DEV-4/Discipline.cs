﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_DEV_4
{
    /// <summary>
    /// class Discipline with lectures
    /// </summary>
    class Discipline : Materials, ICloneable
    {
        public List<Lecture> ListOfLectures { get; set; }

        /// <summary>
        /// Constructor of discipline.
        /// </summary>
        public Discipline(int quantity = 15) : base(random.Next(256))
        {
            this.ListOfLectures = new List<Lecture>();

            for (int i = 0; i < quantity; i++)
            {
                this.ListOfLectures.Add(new Lecture());
            }
        }

        /// <summary>
        /// Constructor of discipline.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Information"></param>
        /// <param name="Lections"></param>
        public Discipline(string Id, string Information, List<Lecture> Lections)
        {
            this.Identi = Id;
            this.TextInformation = Information;
            this.ListOfLectures = new List<Lecture>();

            foreach (var i in Lections)
            {
                this.ListOfLectures.Add((Lecture)i.Clone());
            }
        }

        /// <summary>
        /// method for deep clone object.
        /// </summary>
        /// <returns disciplineClone></returns>
        public object Clone()
        {
            var disciplineClone = new Discipline(this.Identi, this.TextInformation, this.ListOfLectures);

            return disciplineClone;
        }

        /// <summary>
        /// Indexer return to display certain lecture and her seminars and laboratory lessons.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public StringBuilder this[int index]    {  get{ return this.AddInformationAboutDiscipline(this.ListOfLectures[index], index); } }

        /// <summary>
        /// method gather Information About Discipline
        /// </summary>
        /// <param name="listOfLectures"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public StringBuilder AddInformationAboutDiscipline(Lecture listOfLectures, int index)
        {
            var allInformation = new StringBuilder();
            allInformation.Append("Lecture Content:\n");
            allInformation.Append($"{index + 1} lection: seminars - {listOfLectures.ListOfSeminars.Count}" +
                $", laboratories - {listOfLectures.ListOfLaboratoryClasses.Count}.\n");
            allInformation.Append("Detailed Description:\n");
            allInformation.Append($"---Lection {index + 1}th:\n");
            listOfLectures.AddInformationAboutLecture(allInformation);
            allInformation.Append("End.\n");

            return allInformation;
        }
    }
}
