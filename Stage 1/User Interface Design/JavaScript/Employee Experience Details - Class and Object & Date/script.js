function Employee (_name, _designation, _year_of_experience)
{
//fill code here
    this.name = _name;
    this.designation = _designation;
    this.year_of_experience = _year_of_experience;
}

function createEmployee(name, designation, year_of_experience)
{
//fill code here
    return new Employee(name, designation, year_of_experience);
}

function validateObject(employee)
{
//fill code here
    if (employee instanceof Employee){
        var today = new Date();
        var currentYear = today.getFullYear();
        var exp = currentYear - employee.year_of_experience-1;
        return employee.name+" is serving the position of "+employee.designation+" since "+exp;
    }
}

function displayEmployee(name, designation, year_of_experience){
    var emp = createEmployee(name, designation, year_of_experience);
    return validateObject(emp);
    
}

console.log(displayEmployee("Jerold","Manager",15));