﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTutorial {

    class Sqr : Rect {

        public override string Print() {
            return "Sqr";
        }
        public Sqr() { }

        public Sqr(int s1) : base(s1, s1) { }
    }
}
