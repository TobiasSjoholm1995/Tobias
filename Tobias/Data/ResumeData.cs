using System.Collections.Generic;

namespace Tobias.Data
{

    public class Link
    {
        public string Ulr { get; set; }

        public string Text { get; set; }

        public string Target { get; set; }
    }

    public class ResumeData
    {
        public string Filename { get; set; }

        public string Title { get; set; }

        public string Date { get; set; }

        public string Text { get; set; }

        public string CssClass { get; set; }

        public Link Link { get; set; }


        public ResumeData()
        {
            CssClass = string.Empty;
        }



        public static List<ResumeData> GetWorkExperience()
        {
            return new List<ResumeData>
            {
                new  ResumeData {
                    Filename = "SAAB.png",
                    Title    = "SAAB",
                    Date     = "2020 - Today",
                    CssClass = "image-large",
                    Text     = "I Started working at SAAB as a consult for the first 6 months then I got offered a full time job."
                },

                new ResumeData {
                    Filename = "ABB.png",
                    Title    = "ABB",
                    Date     = "2019",
                    CssClass = "image-large",
                    Text     = "In the spring of 2019 I was dooing my master thesis at ABB. I was working with C# in the .NET framework.."
                },

                new ResumeData {
                    Filename = "ABB.png",
                    Title    = "ABB",
                    Date     = "2017 - 2018",
                    CssClass = "image-large",
                    Text     = "For 6 months I was working as software engineer consultant for XAMERA... "
                },

                new ResumeData {
                    Filename = "ABB.png",
                    Title    = "ABB",
                    Date     = "2016",
                    CssClass = "image-large",
                    Text     = "For 6 months I was working as software engineer consultant for XAMERA... "
                },

                new ResumeData {
                    Filename = "KBAB.png",
                    Title    = "KBAB",
                    Date     = "2015",
                    CssClass = "image-normal kbab",
                    Text     = "For 6 months I was working as software engineer consultant for XAMERA... "
                },

                new  ResumeData {
                    Filename = "RealFast.jpg",
                    Title    = "RealFast",
                    Date     = "2011",
                    CssClass = "image-large realfast",
                    Text     = "At the summer of 2011 I was a summer intern at RealFast helping them with a various set "
                             + "of tasks, such as: administration, computer support, configurations and software installation."
                             + "It was a fun experience and my first IT job."
                }
            };
        }

        public static List<ResumeData> GetEducationExperience()
        {
            return new List<ResumeData>
            {
                new  ResumeData {
                    Filename = "KAU.png",
                    Title    = "Karlstad's University",
                    Date     = "2014 - 2019",
                    Text     = "I Started working at SAAB as a consult for the first 6 months then I got offered a full time job."
                },

                new  ResumeData {
                    Filename = "RealFast.jpg",
                    Title    = "RealFast",
                    Date     = "2016",
                    CssClass = "image-large realfast",
                    Text     = "In the spring of 2019 I was dooing my master thesis at ABB. I was working with C# in the .NET framework.."
                             + "In the spring of 2019 I was dooing my master thesis at ABB. I was working with C# in the .NET framework.."
                             + "In the spring of 2019 I was dooing my master thesis at ABB. I was working with C# in the .NET framework.."
                             + "In the spring of 2019 I was dooing my master thesis at ABB. I was working with C# in the .NET framework.."
                             + "In the spring of 2019 I was dooing my master thesis at ABB. I was working with C# in the .NET framework.."
                },

                new  ResumeData {
                    Filename = "Gymnasium.png",
                    Title    = "UtbildningsCentrum",
                    Date     = "2011 - 2014",
                    CssClass = "image-small",
                    Text     = "For 6 months I was working as software engineer consultant for XAMERA... "
                }
            };
        }


        public static List<ResumeData> GetProjectExperience()
        {
            return new List<ResumeData>
            {

                new ResumeData {
                    Filename = "Discord.png",
                    Title    = "Discord Bot",
                    Date     = "2019 - 2020",
                    CssClass = "image-normal",
                    Text     = "Discord is a social media that has an API that allows Bots (programs) to connect to "
                             + "the site and chat with the users. I implemented a Bot in the programming language "
                             + "Python that has over 50 different commands that the users can utilize to interact with the bot. "
                },

                new ResumeData {
                    Filename = "MultiTool.png",
                    Title    = "Multi-Tool",
                    Date     = "2019",
                    CssClass = "image-normal",
                    Text     = "This tool was implemented in the .NET Core Framework. "
                             + "The goal with this project was design a cross-platform tool that has the capabilities "
                             + "to analyze, create and modify data in the form of blocks."
                             + "To visualize the data the third party tool 'Tiled' was used."
                },

                new ResumeData {
                    Filename = "KAU.png",
                    Title    = "NEAT",
                    Date     = "2018",
                    Link     = new Link 
                                { 
                                    Ulr = "https://www.kau.se/en/cs/master-computer-science/make-your-mark-globally-and-locally/neat", 
                                    Target = "_blank", 
                                    Text = "More Info" 
                                },
                    Text     = "NEAT is a internatioanl research project at Karlstad's university that is funded by European Union."
                             + "I was helping making a functional translation of one of a Python module in the NEAT system to the C-language."
                             + "The functional translation drastically increase the performance of the module."
                },

                new ResumeData {
                    Filename = "JabRef.png",
                    Title    = "CabRef",
                    Date     = "2018",
                    CssClass = "image-small",
                    Text     = "CabRef was a project me and 4 other friends implemented at Karlstad's University. The goal of "
                             + "the project was to make a Cloud version of the desktop application JabRef. The backend language used was Java."
                      
                },

                new ResumeData {
                    Filename = "KAU.png",
                    Title    = "KAU's Social Media",
                    Date     = "2017",
                    Text     = "Karlstad's University (KAU) Social Media was a school project that me and 5 other friends was working with. "
                             + "The goal was to make a Facebook similar social media where you can chat with your friends and upload information "
                             + "about yourself and your school courses. The framework used was ASP.NET."
                },

                new ResumeData {
                    Filename = "NCPC.png",
                    Title    = "NCPC",
                    Date     = "2016",
                    CssClass = "image-large",
                    Text     = "Nordic Collegiate Programming Contest (NCPC), is an programming contest "
                             + "that runs in parallel at several universities in Scandinavia. The layout of the contest is simple, "
                             + "you (your team) receive a set of tasks that you need to accurately solve and " 
                             + "the faster you complete them, the better score you get."
                },

                new ResumeData {
                    Filename = "Torium.png",
                    Title    = "Torium Browser",
                    Date     = "2016",
                    CssClass = "image-normal",
                    Link     = new Link { Ulr = "View/Torium", Target = string.Empty, Text = "View Me" },
                    Text     = "Torium Browser I implemented as a WPF project in the .NET Framework. It's built on top of "
                             + "an old Google Chrome Engine. The Torium Browser is fully functional to navigate through the "
                             + "internet with a lot of cool features and animations. "
                },

                new ResumeData {
                    Filename = "Quiz.png",
                    Title    = "Geography Quiz",
                    Date     = "2015",
                    CssClass = "image-small",
                    Link     = new Link { Ulr = "View/Quiz", Target = string.Empty, Text = "View Me" },
                    Text     = "Geography Quiz is a quiz game implemented in WPF with XAML as frontend langauge and C# as backend language. "
                             + "This was one of the first big solo projects I started. The project has 15 000 lines of code."
                }
            };
        }
    }
}
