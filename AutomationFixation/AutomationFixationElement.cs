using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AutomationFixation
{
    public class AutomationFixationElement
    {
        public static IWebElement Element;
        public static IWebDriver Driver = Browser.Driver;

        public AutomationFixationElement(IWebElement element)
        {
            Element = element;
        }

        public AutomationFixationElement Click(int waitTimeInSeconds = 0)
        {
            Element.Click();
            Thread.Sleep(waitTimeInSeconds * 1000);
            return this;
        }

        public AutomationFixationElement Type(string textToType)
        {
            Element.SendKeys(textToType);
            return this;
        }

        public AutomationFixationElement DeleteText()
        {
            Element.Clear();
            return this;
        }

        public AutomationFixationElement Submit()
        {
            Element.Submit();
            return this;
        }

        public string GetText()
        {
            return Element.Text;
        }

        public bool IsEnabled()
        {
            return Element.Enabled;
        }

        public bool IsDisplayed()
        {
            return Element.Displayed;
        }

        public bool IsSelected()
        {
            return Element.Selected;
        }

        public AutomationFixationElement SelectByIndex(int indexToSelect)
        {
            SelectElement select = new SelectElement(Element);
            select.SelectByIndex(indexToSelect);
            return this;
        }

        public AutomationFixationElement SelectByText(string textToSelect)
        {
            SelectElement select = new SelectElement(Element);
            select.SelectByText(textToSelect);
            return this;
        }

        public AutomationFixationElement SelectByValue(string valueToSelect)
        {
            SelectElement select = new SelectElement(Element);
            select.SelectByValue(valueToSelect);
            return this;
        }

        public AutomationFixationElement DeselectAll()
        {
            SelectElement select = new SelectElement(Element);
            select.DeselectAll();
            return this;
        }

        public AutomationFixationElement DeselectByIndex(int indexToDeselect)
        {
            SelectElement select = new SelectElement(Element);
            select.DeselectByIndex(indexToDeselect);
            return this;
        }

        public AutomationFixationElement DeselectByText(string textToDeselect)
        {
            SelectElement select = new SelectElement(Element);
            select.DeselectByText(textToDeselect);
            return this; 
        }

        public AutomationFixationElement DeselectByValue(string valueToDeselect)
        {
            SelectElement select = new SelectElement(Element);
            select.DeselectByValue(valueToDeselect);
            return this;
        }

        public IWebElement GetSelectedOption()
        {
            SelectElement select = new SelectElement(Element);
            return select.SelectedOption;
        }

        public IList<IWebElement> GetAllSelectedOptions()
        {
            SelectElement select = new SelectElement(Element);
            return select.AllSelectedOptions;
        }

        public bool IsMultipleSelect()
        {
            SelectElement select = new SelectElement(Element);
            return select.IsMultiple;
        }

        public static void DragAndDrop(IWebElement elementTo, IWebElement elementFrom)
        {
            Actions action = new Actions(Driver);
            action.DragAndDrop(elementFrom, (IWebElement)elementTo);
        }

    }
}
