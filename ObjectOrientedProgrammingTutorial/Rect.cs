﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTutorial {

    class Rect : Quad {

        public override string Print() {
            return "Rect";
        }
        public int Area() {
            return Side1 * Side2;
        }

        public Rect() : base() { }

        public Rect(int s1, int s2) : base(s1, s2, s1, s2) {

        }
    }
}
