using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez1 = "I";

            await Task.Delay(100);
            var buttonClin = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonClin");
            var buttonOne = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonOne");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;

            buttonClin.Command.Execute(buttonClin.CommandParameter);
            await Task.Delay(50);
            buttonOne.Command.Execute(buttonOne.CommandParameter);
            await Task.Delay(50);

            var textBoxText = textBox.Text as string;
            Assert.True(rez1 == textBoxText);
        }
        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez2 = null;

            await Task.Delay(100);

            var buttonClin = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonClin");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonClin.Command.Execute(buttonClin.CommandParameter);

            await Task.Delay(50);

            var textBoxText = textBox.Text as string;

            Assert.True(rez2 == textBoxText);
        }
        [Fact]
        public async void Test3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez3 = "C+C";

            await Task.Delay(100);

            var buttonHandred = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonHandred");
            var buttonPlas = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonPlas");
            var buttonClin = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonClin");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;
            buttonClin.Command.Execute(buttonClin.CommandParameter);
            await Task.Delay(50);

            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(50);
            buttonPlas.Command.Execute(buttonPlas.CommandParameter);
            await Task.Delay(50);
            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(50);
            
            var textBoxText = textBox.Text as string;

            Assert.True(rez3 == textBoxText);

        }
        [Fact]
        public async void TestSum()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez4 = "CC";

            await Task.Delay(100);

            var buttonHandred = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonHandred");
            var buttonPlas = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonPlas");
            var buttonEquals = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonEquals");
            var buttonClin = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonClin");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;
            buttonClin.Command.Execute(buttonClin.CommandParameter);
            await Task.Delay(50);

            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(50);
            buttonPlas.Command.Execute(buttonPlas.CommandParameter);
            await Task.Delay(50);
            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(50);
            buttonEquals.Command.Execute(buttonEquals.CommandParameter);
            await Task.Delay(50);

            var textBoxText = textBox.Text as string;

            Assert.True(rez4 == textBoxText);

        }
        [Fact]
        public async void TestMinus()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez5 = "nulla";

            await Task.Delay(100);

            var buttonHandred = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonHandred");
            var buttonMinus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonMinus");
            var buttonEquals = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonEquals");
            var buttonClin = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonClin");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;
            buttonClin.Command.Execute(buttonClin.CommandParameter);
            await Task.Delay(50);

            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(50);
            buttonMinus.Command.Execute(buttonMinus.CommandParameter);
            await Task.Delay(50);
            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(50);
            buttonEquals.Command.Execute(buttonEquals.CommandParameter);
            await Task.Delay(50);

            var textBoxText = textBox.Text as string;

            Assert.True(rez5 == textBoxText);

        }
        [Fact]
        public async void TestMultiply()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez6 = "MMD";

            await Task.Delay(100);

            var buttonFifty = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonFifty");
            var buttonMultiply = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonMultiply");
            var buttonEquals = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonEquals");
            var buttonClin = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonClin");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;
            buttonClin.Command.Execute(buttonClin.CommandParameter);
            await Task.Delay(50);

            buttonFifty.Command.Execute(buttonFifty.CommandParameter);
            await Task.Delay(50);
            buttonMultiply.Command.Execute(buttonMultiply.CommandParameter);
            await Task.Delay(50);
            buttonFifty.Command.Execute(buttonFifty.CommandParameter);
            await Task.Delay(50);
            buttonEquals.Command.Execute(buttonEquals.CommandParameter);
            await Task.Delay(50);

            var textBoxText = textBox.Text as string;

            Assert.True(rez6 == textBoxText);
        }
        [Fact]
        public async void TestDivide()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez7 = "I";

            await Task.Delay(100);

            var buttonFifty = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonFifty");
            var buttonDivide = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonDivide");
            var buttonEquals = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonEquals");
            var buttonClin = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonClin");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;
            buttonClin.Command.Execute(buttonClin.CommandParameter);
            await Task.Delay(50);

            buttonFifty.Command.Execute(buttonFifty.CommandParameter);
            await Task.Delay(50);
            buttonDivide.Command.Execute(buttonDivide.CommandParameter);
            await Task.Delay(50);
            buttonFifty.Command.Execute(buttonFifty.CommandParameter);
            await Task.Delay(50);
            buttonEquals.Command.Execute(buttonEquals.CommandParameter);
            await Task.Delay(50);

            var textBoxText = textBox.Text as string;

            Assert.True(rez7 == textBoxText);
        }
    }
}