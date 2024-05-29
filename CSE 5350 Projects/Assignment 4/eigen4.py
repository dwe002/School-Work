import numpy as np

# Define the matrix A
A = np.array([[2, 3, 2], [10, 3, 4], [3, 6, 1]])

# Part a: power iteration for dominant eigenvalue and eigenvector

# Set the initial vector x0
x0 = np.array([0, 0, 1]).reshape(-1, 1)

# Set the maximum number of iterations
max_iter = 100

# Set the tolerance for convergence
tol = 1e-6

# Initialize the eigenvalue and eigenvector
lambda_old = 0
x_old = x0

# Power iteration loop
for i in range(max_iter):
    x_new = A @ x_old
    lambda_new = np.linalg.norm(x_new, ord=np.inf)
    x_new = x_new / lambda_new
    if np.abs(lambda_new - lambda_old) < tol:
        break
    lambda_old = lambda_new
    x_old = x_new

# Print the results
print("Part a:")
print("Dominant eigenvalue:", lambda_new)
print("Corresponding eigenvector:\n", x_new)

# Part b: deflate and power iteration for second largest eigenvalue and eigenvector

# Deflate out the dominant eigenvalue and eigenvector
B = A - lambda_new * x_new @ x_new.T

# Set the initial vector y0 orthogonal to x_new
y0 = np.random.rand(3, 1)
y0 = y0 - y0.T @ x_new * x_new
y0 = y0 / np.linalg.norm(y0)

# Set the maximum number of iterations
max_iter = 100

# Set the tolerance for convergence
tol = 1e-6

# Initialize the eigenvalue and eigenvector
mu_old = 0
y_old = y0

# Power iteration loop
for i in range(max_iter):
    y_new = B @ y_old
    mu_new = np.linalg.norm(y_new, ord=np.inf)
    y_new = y_new / mu_new
    if np.abs(mu_new - mu_old) < tol:
        break
    mu_old = mu_new
    y_old = y_new

# Print the results
print("Part b:")
print("Second largest eigenvalue:", mu_new)
print("Corresponding eigenvector:\n", y_new)

# Part c: NumPy eigensystem function

# Compute all eigenvalues and eigenvectors of A
eigvals, eigvecs = np.linalg.eig(A)

# Print the results
print("Part c:")
print("Eigenvalues:", eigvals)
print("Eigenvectors:\n", eigvecs)

# Compare with part a
print("Dominant eigenvalue difference:", np.abs(eigvals[0] - lambda_new))
print("Corresponding eigenvector difference:", np.linalg.norm(eigvecs[:, 0] - x_new))

# Compare with part b
print("Second largest eigenvalue difference:", np.abs(eigvals[1] - mu_new))
print("Corresponding eigenvector difference:", np.linalg.norm(eigvecs[:, 1] - y_new))