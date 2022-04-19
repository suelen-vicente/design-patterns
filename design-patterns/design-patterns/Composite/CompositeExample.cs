namespace design_patterns.Composite
{
    public class CompositeExample
    {
        public void example()
        {
            Patron patron1 = new Patron(1, "Patron One");
            Patron patron2 = new Patron(2, "Patron Two");
            UserHierarchy patrons = new UserHierarchy();
            patrons.add(patron1);
            patrons.add(patron2);

            Staff staff1 = new Staff(3, "Staff One");
            Staff staff2 = new Staff(4, "Staff Two");
            UserHierarchy eLibraryStaffs = new UserHierarchy();
            eLibraryStaffs.add(staff1);
            eLibraryStaffs.add(staff2);

            UserHierarchy allUsers = new UserHierarchy();
            allUsers.add(patrons);
            allUsers.add(eLibraryStaffs);
            allUsers.display();
        }
    }
}
