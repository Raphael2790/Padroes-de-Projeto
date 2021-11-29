using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Composite
{
    public class CompositeExecution
    {
        public static void Execute()
        {
            var registerValidation = new Message("O cadastro não foi realizado!");
            var userFormError = new Message("O usuário informou um nome inválido");

            var nameLenghtForm = new InputFormMessage("O nome precisa ter mais de 2 caracteres");
            var numbersInNameForm = new InputFormMessage("O nome não pode ter números");

            userFormError.AddChild(nameLenghtForm);
            userFormError.AddChild(numbersInNameForm);

            registerValidation.AddChild(userFormError);

            var userDomainError = new Message("Problemas ao realizar cadastro do usuário");

            var userCPFDomain = new DomainMessage("O CPF informado está em uso!");
            var userEmailDomain = new DomainMessage("O e-mail informado está em uso!");

            userDomainError.AddChild(userCPFDomain);
            userDomainError.AddChild(userEmailDomain);

            registerValidation.AddChild(userDomainError);

            registerValidation.ShowMessages(2);
        }
    }
}
