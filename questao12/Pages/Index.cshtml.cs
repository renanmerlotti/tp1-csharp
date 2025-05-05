using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using questao12.Models;
using System;

public class CreateEventModel : PageModel
{
    public static Action<Event> OnEventCreated = e => { };

    [BindProperty]
    public Event Evento { get; set; } = new Event();

    public void OnGet() { }

    public void OnPost()
    {
        OnEventCreated?.Invoke(Evento);
    }
}