namespace VMS.DAL.DataContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using VMS.Model;

    public partial class VMSDataContext : DbContext
    {
        public VMSDataContext()
            : base("name=VMSDataContext")
        {
        }
        public virtual DbSet<Accomodation> Accomodations { get; set; }
        public virtual DbSet<Allergy> Allergies { get; set; }
        public virtual DbSet<BlackList> BlackLists { get; set; }
        public virtual DbSet<Committee> Committees { get; set; }
        public virtual DbSet<CommitteeType> CommitteeTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Deployment> Deployments { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public virtual DbSet<HajjSession> HajjSessions { get; set; }
        public virtual DbSet<IqamaDetail> IqamaDetails { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<RegionCommittee> RegionCommittees { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SubCommittee> SubCommittees { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskAssigned> TaskAssigneds { get; set; }
        public virtual DbSet<TaskLogging> TaskLoggings { get; set; }
        public virtual DbSet<TaskPriority> TaskPriorities { get; set; }
        public virtual DbSet<TaskStatu> TaskStatus { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamDeployment> TeamDeployments { get; set; }
        public virtual DbSet<TeamVolunteer> TeamVolunteers { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<TrainingOffered> TrainingOffereds { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<VolunteerAllergy> VolunteerAllergies { get; set; }
        public virtual DbSet<VolunteerMessage> VolunteerMessages { get; set; }
        public virtual DbSet<VolunteerSkill> VolunteerSkills { get; set; }
        public virtual DbSet<VolunteerTraining> VolunteerTrainings { get; set; }
        public virtual DbSet<WorkerType> WorkerTypes { get; set; }
        public virtual DbSet<WorkHour> WorkHours { get; set; }
        public virtual DbSet<CommitteeVolunteer> CommitteeVolunteers { get; set; }
        public virtual DbSet<VolunteerEmergencyContact> VolunteerEmergencyContacts { get; set; }
        public virtual DbSet<VolunteerLanguage> VolunteerLanguages { get; set; }
        public virtual DbSet<VolunteerSecurityQuestion> VolunteerSecurityQuestions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Committee>()
            //    .Property(e => e.Name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CommitteeType>()
            //    .Property(e => e.Name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Country>()
            //    .Property(e => e.Abbreviation)
            //    .IsUnicode(false);

            //modelBuilder.Entity<HajjSession>()
            //    .Property(e => e.Year)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Permission>()
            //    .HasMany(e => e.Roles)
            //    .WithMany(e => e.Permissions)
            //    .Map(m => m.ToTable("RolePermission").MapLeftKey("PermissionID").MapRightKey("RoleID"));

            //modelBuilder.Entity<Region>()
            //    .Property(e => e.Name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Role>()
            //    .HasMany(e => e.Volunteers)
            //    .WithMany(e => e.Roles)
            //    .Map(m => m.ToTable("VolunteerRole").MapLeftKey("RoleID").MapRightKey("VolunteerID"));

            //modelBuilder.Entity<SubCommittee>()
            //    .Property(e => e.Name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Team>()
            //    .HasMany(e => e.TaskAssigneds)
            //    .WithOptional(e => e.Team)
            //    .HasForeignKey(e => e.AssignedToTeamID);

            //modelBuilder.Entity<Training>()
            //    .HasMany(e => e.Volunteers)
            //    .WithMany(e => e.Trainings)
            //    .Map(m => m.ToTable("TrainingInstructor").MapLeftKey("TrainingID").MapRightKey("VolunteerID"));

            //modelBuilder.Entity<Volunteer>()
            //    .HasMany(e => e.Messages)
            //    .WithOptional(e => e.Volunteer)
            //    .HasForeignKey(e => e.SendBy);

            //modelBuilder.Entity<Volunteer>()
            //    .HasMany(e => e.Tasks)
            //    .WithOptional(e => e.Volunteer)
            //    .HasForeignKey(e => e.CreatedBy);

            //modelBuilder.Entity<Volunteer>()
            //    .HasMany(e => e.TaskAssigneds)
            //    .WithOptional(e => e.Volunteer)
            //    .HasForeignKey(e => e.AssignedToCommitteeVolunteerID);

            //modelBuilder.Entity<Volunteer>()
            //    .HasMany(e => e.TaskAssigneds1)
            //    .WithOptional(e => e.Volunteer1)
            //    .HasForeignKey(e => e.AssignedBy);

            //modelBuilder.Entity<Volunteer>()
            //    .HasMany(e => e.Vehicles)
            //    .WithOptional(e => e.Volunteer)
            //    .HasForeignKey(e => e.OwnerID);
        }
    }
}
