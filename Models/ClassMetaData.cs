using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace SchoolManagementApp.MVC.Data;

public class ClassMetaData
{
    [Display(Name="Lecturer")]
    public int LecturerId { get; set; }
    [Display(Name="Course")]
    public int CourseId { get; set; }
}

[ModelMetadataType(typeof(ClassMetaData))]
public partial class Class{}