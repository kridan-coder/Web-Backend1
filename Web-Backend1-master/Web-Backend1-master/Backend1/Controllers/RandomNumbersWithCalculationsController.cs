using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend1.Models;
using Backend1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend1.Controllers
{
    public class RandomNumbersWithCalculationsController : Controller
    {
        private readonly IRandomNumberInRangeService randomNumberInRangeService;
        private readonly ICalculationService calculationService;

        public RandomNumbersWithCalculationsController(IRandomNumberInRangeService randomNumberInRangeService, ICalculationService calculationService)
        {
            this.randomNumberInRangeService = randomNumberInRangeService;
            this.calculationService = calculationService;
        }

        public ActionResult PassUsingViewData()
        {
            var number_1 = this.randomNumberInRangeService.GenerateRandomNumber();
            var number_2 = this.randomNumberInRangeService.GenerateRandomNumber();
            this.ViewData["Number1"] = number_1;
            this.ViewData["Number2"] = number_2;
            this.ViewData["AdditionResult"] = this.calculationService.Addition(number_1, number_2);
            this.ViewData["SubstractionResult"] = this.calculationService.Substraction(number_1, number_2);
            this.ViewData["MultiplicationResult"] = this.calculationService.Multiplication(number_1, number_2);
            //this.ViewData["DivisionResult"] = this.calculationService.Division(number_1, number_2);

            var division_result = this.calculationService.Division(number_1, number_2);
            if (division_result == null)
            {
                this.ViewData["DivisionResult"] = "division by zero is undefined";
            }
            else
            {
                this.ViewData["DivisionResult"] = division_result;
            }
            return this.View();
        }

        public ActionResult PassUsingViewBag()
        {
            var number_1 = this.randomNumberInRangeService.GenerateRandomNumber();
            var number_2 = this.randomNumberInRangeService.GenerateRandomNumber();
            this.ViewBag.Number1 = number_1;
            this.ViewBag.Number2 = number_2;
            this.ViewBag.AdditionResult = this.calculationService.Addition(number_1, number_2);
            this.ViewBag.SubstractionResult = this.calculationService.Substraction(number_1, number_2);
            this.ViewBag.MultiplicationResult = this.calculationService.Multiplication(number_1, number_2);
            //this.ViewData["DivisionResult"] = this.calculationService.Division(number_1, number_2);

            var division_result = this.calculationService.Division(number_1, number_2);
            if (division_result == null)
            {
                this.ViewBag.DivisionResult = "division by zero is undefined";
            }
            else
            {
                this.ViewBag.DivisionResult = division_result;
            }
            return this.View();
        }

        public ActionResult PassUsingModel()
        {
            var number_1 = this.randomNumberInRangeService.GenerateRandomNumber();
            var number_2 = this.randomNumberInRangeService.GenerateRandomNumber();

            var model = new ShowNumberModel
            {
                GeneratedNumber1 = number_1, GeneratedNumber2 = number_2,
                AdditionResult = this.calculationService.Addition(number_1, number_2),
                SubstractionResult = this.calculationService.Substraction(number_1, number_2),
                MultiplicationResult = this.calculationService.Multiplication(number_1, number_2),
                DivisionResult = this.calculationService.Division(number_1, number_2)
            };

            return this.View(model);
        }

        public ActionResult AccessServiceDirectly()
        {
            return this.View();
        }
    }
}
