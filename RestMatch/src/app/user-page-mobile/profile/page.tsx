const UserProfile = () => {
  return (
    <div className="w-full">
      <div className="bg-[#9f784e] pl-10 pr-10 pt-3 flex flex-col w-full md:pl-20 pr-44 pt-16">
        <h1 className="hidden md:mb-5">Profile</h1>
        <div className="mb-5 text-[35px] font-bold md:hidden">Profile</div>
        <form className="flex flex-col gap-5 items-end">
          <div className="flex flex-col gap-3 w-full">
            <label className="text-[20px] md:text-3xl">
              First Name and Last Name
            </label>
            <input className="h-14 rounded-[20px]" />
          </div>
          <div className="flex flex-col gap-3 w-full">
            <label className="text-[20px] md:text-3xl">Nickname</label>
            <input className="h-14 rounded-[20px]" />
          </div>
          <div className="flex flex-col gap-3 w-full">
            <label className="text-[20px] md:text-3xl">Email</label>
            <input className="h-14 rounded-[20px]" type="email" />
          </div>
          <div className="flex flex-col gap-3 mb-4 w-full">
            <label className="text-[20px] md:text-3xl">Phone Number</label>
            <input className="h-14 rounded-[20px]" />
          </div>
          <div className="flex mb-5">
            <button className="px-5 text-lg py-3 mr-8 w-fit font-bold rounded-3xl bg-[#695858]">
              Upload photo
            </button>
            <button className="px-5 text-lg py-3 w-fit font-bold rounded-3xl bg-[#565656]">
              Show photo
            </button>
          </div>
          <button className="w-56 h-12 bg-[#F0BB81] rounded-[18px] text-[#5D462D] text-[24px] translate-x-[10%] font-bold md:w-64 h-14 text-[2rem] translate-x-[40%]">
            Change info
          </button>
        </form>
      </div>
    </div>
  );
};

export default UserProfile;
