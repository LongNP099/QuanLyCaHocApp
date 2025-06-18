using System;
using System.Collections.Generic;
public class ClassSession
{
    public string ClassID { get; set; }
    public string Subject { get; set; }
    public DateTime Schedule { get; set; }
    public Teacher Instructor { get; set; }

    public ClassSession(string classID, string subject, DateTime schedule, Teacher instructor)
    {
        ClassID = classID;
        Subject = subject;
        Schedule = schedule;
        Instructor = instructor;
    }

    public override string ToString()
    {
        string teacher = Instructor != null ? Instructor.Name : "None";
        return $"[ClassID: {ClassID}, Subject: {Subject}, Time: {Schedule}, Teacher: {teacher}]";
    }
}