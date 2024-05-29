
a11 = input('Please input a11: ');
a12 = input('Please input a12: ');
a21 = input('Please input a21: ');
a22 = input('Please input a22: ');

matrixA = [a11 a12; a21 a22]

disp("Matrix A: ")
disp(matrixA)

matrixB = symmetrize2x2matrix(MatrixA)

disp("Matrix B: ", matrixB)

function matrixB = symmetrize2x2matrix(matrixA)

a12 = matrixA(1, 2);
a21 = matrixA(2, 1);

normOfDiagnal = sqrt(a12^2 + a21^2);

if normOfDiagnal == 0
    matrixB = matrixA;
    return
end

c = a12 / normOfDiagnal;
s = a21 / normOfDiagnal;
theta = atan2(s, c);

matrixR = [cose(theta), -sin(theta); sin(theta), cos(theta)];
matrixA = matrixR * matrixA * matrixR';
matrixB = (matrixA + matrixA') / 2;
end
