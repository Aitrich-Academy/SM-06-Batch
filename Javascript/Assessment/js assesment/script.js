function handleSubmit(e) {
  
    
    const password = document.getElementById('password').value;
    const confirm = document.getElementById('confirmPassword').value;





    if (password !== confirm) {
      alert("Passwords do not match!");
      return false;
    }
  
    alert("Form submitted successfully!");
    return true;
  }
  function valid(email) {
    const pattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return pattern.test(email);
}
const email = "example@domain.com";
console.log(valid(email) ? "Valid email address" : "Invalid email address");
