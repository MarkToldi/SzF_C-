public class CustomerService
{
    private readonly List<CustomerModel> _customers = new List<CustomerModel>();
    private int _nextId = 1;

    public List<CustomerModel> GetAllCustomers() => _customers;

    public CustomerModel? GetCustomerById(int id) => 
        _customers.FirstOrDefault(c => c.Id == id);

    public CustomerModel CreateCustomer(CustomerModel customer)
    {
        customer.Id = _nextId++;
        _customers.Add(customer);
        return customer;
    }

    public bool UpdateCustomer(int id, CustomerModel updatedCustomer)
    {
        var existingCustomer = _customers.FirstOrDefault(c => c.Id == id);
        if (existingCustomer == null) return false;

        existingCustomer.Name = updatedCustomer.Name;
        existingCustomer.Email = updatedCustomer.Email;
        existingCustomer.Phone = updatedCustomer.Phone;
        existingCustomer.Location = updatedCustomer.Location;

        return true;
    }

    public bool DeleteCustomer(int id)
    {
        var customer = _customers.FirstOrDefault(c => c.Id == id);
        if (customer == null) return false;

        _customers.Remove(customer);
        return true;
    }



}