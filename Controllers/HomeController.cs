using Microsoft.AspNetCore.Mvc;
using VocabCard.Data;
using VocabCard.Models;

namespace VocabCard.Controllers;

public class HomeController : Controller
{
    private readonly VoclearnContext _context;
    public HomeController(VoclearnContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Card()
    {
        var uniqueDates = _context.Card
            .GroupBy(x => x.UploadTime.Date)
            .Select(d => d.Key)
            .ToList();
        return View(uniqueDates);
    }
    public IActionResult FlashCards(DateTime date)
    {
        var cards = _context.Card
            .Where(c => c.UploadTime.Date == date.Date)
            .ToList();

        return View(cards);
    }
    public IActionResult Delete(DateTime date)
    {
        var cardsToDelete = _context.Card
            .Where(c => c.UploadTime.Date == date.Date)
            .ToList();

        if (cardsToDelete.Any())
        {
            _context.Card.RemoveRange(cardsToDelete);
            _context.SaveChanges();
        }

        return RedirectToAction("Card");
    }
    public IActionResult DeleteCard(int cardId)
    {
        var deleteCard = _context.Card.FirstOrDefault(c => c.CardId == cardId);
        if (deleteCard != null)
        {
            _context.Card.Remove(deleteCard);
            _context.SaveChanges();
        }
        return RedirectToAction("Card");
    }
    public IActionResult EditCard(int cardId)
    {
        var editCard = _context.Card.FirstOrDefault(c => c.CardId == cardId);
        if (editCard == null)
        {
            return NotFound();
        }
        return View(editCard);
    }
    [HttpPost]
    public IActionResult EditCard(Card card)
    {
        if (ModelState.IsValid)
        {
            var existingCard = _context.Card.FirstOrDefault(c => c.CardId == card.CardId);
            if (existingCard != null)
            {
                existingCard.Word = card.Word;
                existingCard.Example = card.Example;
                existingCard.Mean = card.Mean;

                _context.SaveChanges();
                return RedirectToAction("Card");
            }

            return NotFound();
        }

        // Hata durumunda, geçersiz model ile formu geri döndürün.
        return View(card);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Card card)
    {
        if (ModelState.IsValid)
        {
            card.UploadTime = DateTime.Now.Date;
            _context.Card.Add(card);
            await _context.SaveChangesAsync();
            return RedirectToAction("Card");
        }
        return View(card);
    }
    public IActionResult WordList()
    {
        var words = _context.Card
            .ToList();
        return View(words);
    }
}
