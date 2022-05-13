using FluentValidation;
using NSchicht.Core.Konkret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.ArbeitsEinheit.Validierung
{
    public class AktenmappeValidator: AbstractValidator<Aktenmappe>
    {
        public AktenmappeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Der Projektname darf nicht weggelassen werden.");
            RuleFor(x => x.BildUrl).NotEmpty().WithMessage("Das Bildfeld darf nicht leer bleiben.");
            RuleFor(x => x.ProjektUrlBild).NotEmpty().WithMessage("Das Bildfeld darf nicht leer bleiben.");
            RuleFor(x => x.Preis).NotEmpty().WithMessage("Das Preisfeld darf nicht leer bleiben.");
            RuleFor(x => x.Proportion).NotEmpty().WithMessage("Das Proportionsfeld darf nicht leer bleiben.");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Der Projektname muss mindestens 5 Zeichen enthalten.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Der Projektname muss maximal 100 Zeichen enthalten.");

        }
    }
}
