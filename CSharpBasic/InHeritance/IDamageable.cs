using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InHeritance
{
    // interface
    // 멤버들의 접근제한자는 기본적으로 public.
    internal interface IDamageable
    {
        void Damage(float amount
            );
    }
}
