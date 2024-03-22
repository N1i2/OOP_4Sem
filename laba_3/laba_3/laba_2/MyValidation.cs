using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    class MyValidation:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value is int sem)
            {
                if(sem != 0)
                {
                    return true;
                }
                else
                {
                    ErrorMessage =  "Semester is Empty";
                }
            }

            return false;
        }
    }
}
