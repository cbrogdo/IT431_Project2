using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MasonDatabase.Models
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<ApplicationsContext>
    {
        protected override void Seed(ApplicationsContext context)
        {
            IList<Major> defaultMajor = new List<Major>();
            defaultMajor.Add(new Major() { MajorOption = "-Select a major-" });
            defaultMajor.Add(new Major() { MajorOption = "Anthropology" });
            defaultMajor.Add(new Major() { MajorOption = "Applied Computer Science" });
            defaultMajor.Add(new Major() { MajorOption = "Applied Science" });
            defaultMajor.Add(new Major() { MajorOption = "Art and Visual Technology" });
            defaultMajor.Add(new Major() { MajorOption = "Art and Visual Technology" });
            defaultMajor.Add(new Major() { MajorOption = "Art History" });
            defaultMajor.Add(new Major() { MajorOption = "Astronomy" });
            defaultMajor.Add(new Major() { MajorOption = "Atmospheric Sciences" });
            defaultMajor.Add(new Major() { MajorOption = "Bioengineering" });
            defaultMajor.Add(new Major() { MajorOption = "Biology" });
            defaultMajor.Add(new Major() { MajorOption = "Business" });
            defaultMajor.Add(new Major() { MajorOption = "Chemistry" });
            defaultMajor.Add(new Major() { MajorOption = "Civil and Infrastructure Engineering" });
            defaultMajor.Add(new Major() { MajorOption = "Communication" });
            defaultMajor.Add(new Major() { MajorOption = "Community Health" });
            defaultMajor.Add(new Major() { MajorOption = "Computational and Data Sciences" });
            defaultMajor.Add(new Major() { MajorOption = "Computer Engineering" });
            defaultMajor.Add(new Major() { MajorOption = "Computer Game Design" });
            defaultMajor.Add(new Major() { MajorOption = "Computer Science" });
            defaultMajor.Add(new Major() { MajorOption = "Conflict Analysis and Resolution" });
            defaultMajor.Add(new Major() { MajorOption = "Creative Writing" });
            defaultMajor.Add(new Major() { MajorOption = "Criminology, Law, and Society" }); 
            defaultMajor.Add(new Major() { MajorOption = "Cyber Security Engineering" });
            defaultMajor.Add(new Major() { MajorOption = "Dance" });
            defaultMajor.Add(new Major() { MajorOption = "Early Childhood Education for Diverse Learners" });
            defaultMajor.Add(new Major() { MajorOption = "Economics" });
            defaultMajor.Add(new Major() { MajorOption = "Electrical Engineering" });
            defaultMajor.Add(new Major() { MajorOption = "Elementary Education" });
            defaultMajor.Add(new Major() { MajorOption = "English" });
            defaultMajor.Add(new Major() { MajorOption = "Environmental and Sustainability Studies" });
            defaultMajor.Add(new Major() { MajorOption = "Environmental Science" });
            defaultMajor.Add(new Major() { MajorOption = "Film and Video Studies" });
            defaultMajor.Add(new Major() { MajorOption = "Foreign Languages" });
            defaultMajor.Add(new Major() { MajorOption = "Forensic Science" });
            defaultMajor.Add(new Major() { MajorOption = "Geography" });
            defaultMajor.Add(new Major() { MajorOption = "Geology" });
            defaultMajor.Add(new Major() { MajorOption = "Global Affairs" });
            defaultMajor.Add(new Major() { MajorOption = "Government and International Politics" });
            defaultMajor.Add(new Major() { MajorOption = "Health Administration" });
            defaultMajor.Add(new Major() { MajorOption = "Health Informatics" });
            defaultMajor.Add(new Major() { MajorOption = "Health, Fitness, and Recreation Resources" });
            defaultMajor.Add(new Major() { MajorOption = "History" });
            defaultMajor.Add(new Major() { MajorOption = "Human Development and Family Science" });
            defaultMajor.Add(new Major() { MajorOption = "Individualized Study" });
            defaultMajor.Add(new Major() { MajorOption = "Information Technology" });
            defaultMajor.Add(new Major() { MajorOption = "Integrative Studies" });
            defaultMajor.Add(new Major() { MajorOption = "Kinesiology" });
            defaultMajor.Add(new Major() { MajorOption = "Mathematics" });
            defaultMajor.Add(new Major() { MajorOption = "Mechanical Engineering" });
            defaultMajor.Add(new Major() { MajorOption = "Mediacl Laboratory Science" });
            defaultMajor.Add(new Major() { MajorOption = "Music" });
            defaultMajor.Add(new Major() { MajorOption = "Neuroscience" });
            defaultMajor.Add(new Major() { MajorOption = "Nursing" });
            defaultMajor.Add(new Major() { MajorOption = "Philosophy" });
            defaultMajor.Add(new Major() { MajorOption = "Physical Education" });
            defaultMajor.Add(new Major() { MajorOption = "Physics" });
            defaultMajor.Add(new Major() { MajorOption = "Psychology" });
            defaultMajor.Add(new Major() { MajorOption = "Public Administration" });
            defaultMajor.Add(new Major() { MajorOption = "Recreation Management"});
            defaultMajor.Add(new Major() { MajorOption = "Religious Studies" });
            defaultMajor.Add(new Major() { MajorOption = "Russian and Eurasian Studies" });
            defaultMajor.Add(new Major() { MajorOption = "Social Work" });
            defaultMajor.Add(new Major() { MajorOption = "Sociology" });
            defaultMajor.Add(new Major() { MajorOption = "Special Education" });
            defaultMajor.Add(new Major() { MajorOption = "Sport Management" });
            defaultMajor.Add(new Major() { MajorOption = "Statistics" });
            defaultMajor.Add(new Major() { MajorOption = "System Engineering" });
            defaultMajor.Add(new Major() { MajorOption = "Theater" });
            defaultMajor.Add(new Major() { MajorOption = "Tourism and Events Management" });
            context.Majors.AddRange(defaultMajor);


            IList<Semester> defaultSemester = new List<Semester>();
            defaultSemester.Add(new Semester() { EnrollSem = "-Select a semester-" });
            defaultSemester.Add(new Semester() { EnrollSem = "Fall" });
            defaultSemester.Add(new Semester() { EnrollSem = "Spring" });
            defaultSemester.Add(new Semester() { EnrollSem = "Summer" });
            context.Semesters.AddRange(defaultSemester);

            base.Seed(context);
        }
    }
}