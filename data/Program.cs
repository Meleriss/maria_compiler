REM FUNCTION INTEGER test(INTEGER f, INTEGER a)
	DIM buf AS INTEGER
	DIM ch AS CHAR
	buf = 4
	ch = 'a'
	DIM arr = INTEGER(5) AS INTEGER
	arr[3] = 3
	DIM arr2 = CHAR(5) AS CHAR
	IF arr[3] - 3
	THEN
		DIM test AS CHAR
		f = 3
		outputStr("test")
	END IF
	RETURN 4 + arr[2] *a
END FUNCTION

REM FUNCTION INTEGER cout_iter(INTEGER a)
	RETURN a + 1
END FUNCTION

REM FUNCTION INTEGER Main()
	DIM f AS INTEGER
	DIM a AS INTEGER

	f = 6
	a = f + -4

	test(4, f + -4)
	
	DIM b AS INTEGER
	b = 5
	a = ((b < 4) + -4 < 3) * 3
	outputInt(a)

	DIM i AS INTEGER
	i = 0
	DO WHILE (i < 5)
		outputStr("loop")
		outputInt(i)
		i = i + 1
	LOOP

	DIM cond AS INTEGER
	cond = 2
	IF cond >= 2
	THEN
		outputStr("true")
	END IF

	RETURN 0
END FUNCTION