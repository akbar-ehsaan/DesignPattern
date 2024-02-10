using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Factory
{
    public abstract class Page
    {

    }

    public class SkillPage : Page
    {

    }

    public class EducationPage : Page
    {

    }

    public class ExpriencePage : Page
    {

    }

    public class IntroductionPage : Page
    {

    }

    public class ResultPage : Page
    {

    }

    public class ConclusionPage : Page
    {

    }
    public class SummaryPage : Page
    {

    }

    public class BibliographyPage : Page
    {

    }

    public abstract class Document
    {
        List<Page> _pages = new();

        public Document()
        {
            this.CreatePage();
        }
        public List<Page> Pages
        {
            get => _pages;
        }
        public abstract void CreatePage();
    }

    public class Resume : Document
    {
        public override void CreatePage()
        {
            Pages.Add(new SkillPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExpriencePage());
        }
    }
    public class Report : Document
    {
        public override void CreatePage()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
