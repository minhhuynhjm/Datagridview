namespace CRManagmentSystem.Models.FacilitySystem
{
    public class SystemTypeModel
    {
        /// <summary>
        /// A.DIVISIONNAME + ":" + B.DIVISIONNAME
        /// </summary>
        public string DIV_NAME { get; set; }

        /// <summary>
        /// PARENT_ID
        /// </summary>
        public string PARENT_ID { get; set; }

        /// <summary>
        /// CHILD_ID
        /// </summary>
        public string CHILD_ID { get; set; }
    }
}
