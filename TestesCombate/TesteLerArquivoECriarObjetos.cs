﻿using System;
using System.Collections.Generic;
using Goku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesCombate
{
    [TestClass]
    public class TesteLerArquivoECriarObjetos
    {
        [TestMethod]
        public void TesteSucesso()
        {
            var texto = @"3 4 4 2
7 10
13 20
25 50
1 2
2 4
1 3
3 4
2 125
3 160
3 4 4 1
7 10
13 20
25 50
1 2
2 4
1 3
3 4
2 125
1 3 1 1
1000 1000
1 2
3 1000
0 0 0 0";

            bool resultado = Estruturas.LerArquivo(null, texto);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TesteSucesso1()
        {
            var texto = @"10 20 20 40
11 22
12 24
13 26
14 28
15 30
16 32
17 34
18 36
19 38
20 40
1 2
2 5
1 3
3 4
4 7
5 6
6 9
7 8
8 11
9 10
10 13
11 12
12 15
13 14
14 17
15 16
16 19
17 18
18 20
19 20
1 200
1 200
2 200
2 200
3 200
3 200
4 200
4 200
5 200
5 200
6 200
6 200
7 200
7 200
8 200
8 200
9 200
9 200
10 200
10 200
11 200
11 200
12 200
12 200
13 200
13 200
14 200
14 200
15 200
15 200
16 200
16 200
17 200
17 200
18 200
18 200
19 200
19 200
20 200
20 200
10 20 20 40
11 22
12 24
13 26
14 28
15 30
16 32
17 34
18 36
19 38
20 40
1 2
2 5
1 3
3 4
4 7
5 6
6 9
7 8
8 11
9 10
10 13
11 12
12 15
13 14
14 17
15 16
16 19
17 18
18 20
19 20
1 400
1 400
2 400
2 400
3 400
3 400
4 400
4 400
5 400
5 400
6 400
6 400
7 400
7 400
8 400
8 400
9 400
9 400
10 400
10 400
11 400
11 400
12 400
12 400
13 400
13 400
14 400
14 400
15 400
15 400
16 400
16 400
17 400
17 400
18 400
18 400
19 400
19 400
20 400
20 400
10 20 20 40
11 22
12 24
13 26
14 28
15 30
16 32
17 34
18 36
19 38
20 40
1 2
2 5
1 3
3 4
4 7
5 6
6 9
7 8
8 11
9 10
10 13
11 12
12 15
13 14
14 17
15 16
16 19
17 18
18 20
19 20
1 500
1 500
2 500
2 500
3 500
3 500
4 500
4 500
5 500
5 500
6 500
6 500
7 500
7 500
8 500
8 500
9 500
9 500
10 500
10 500
11 500
11 500
12 500
12 500
13 500
13 500
14 500
14 500
15 500
15 500
16 500
16 500
17 500
17 500
18 500
18 500
19 500
19 500
20 500
20 500
0 0 0 0";

            bool resultado = Estruturas.LerArquivo(null, texto);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TesteSucesso2()
        {
            var texto = @"3 4 4 2
-7 10
-13 -20
25 -50
1 2
2 4
1 3
3 4
2 -125
3 160
3 4 4 1
7 10
13 20
25 50
1 2
2 4
1 3
3 4
2 125
1 3 1 1
1000 1000
1 2
3 1000
0 0 0 0";

            bool resultado = Estruturas.LerArquivo(null, texto);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TesteErro()
        {
            var texto = @"3 4 4 2,
7 10,
13 20,
25 50,
1 2,
2 4,
1 3,
3 4,
2 125,
3 160,
3 4 4 1,
7 10,
13 20,
25 50,
1 2,
2 4,
1 3,
3 4,
2 125,
1 3 1 1,
1000 1000,
1 2,
3 1000,
0 0 0 0";

            bool resultado = Estruturas.LerArquivo(null, texto);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TesteErro1()
        {
            var texto = @"dsadsadsadsadsads";

            bool resultado = Estruturas.LerArquivo(null, texto);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TesteErro2()
        {
            var texto = @"1 1 1 1
7 10
13 20
25 50
1 2
2 4
1 3
3 4
2 125
3 160
3 4 4 1
7 10
13 20
25 50
1 2
2 4
1 3
3 4
2 125
1 3 1 1
1000 1000
1 2
3 1000
0 0 0 0";

            bool resultado = Estruturas.LerArquivo(null, texto);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TesteErro3()
        {
            var texto = @"3a 4 4 2
7 10
13 20
25 50
1 2
2 4
1 3
3 4
2 125
3 160
3 4 4 1
7 10
13 20
25 50
1 2
2 4
1 3
3 4
2 125
1 3 1 1
1000 1000
1 2
3 1000
0 0 0 0";

            bool resultado = Estruturas.LerArquivo(null, texto);
            Assert.IsFalse(resultado);
        }
    }
}
