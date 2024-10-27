import RestaurantCard from "@/components/search-page/restaurant-card";
import { imageUrl } from "@/utils/constants";

const SearchPage = () => {
  return (
    <div className="bg-[#9F784E] flex flex-col w-full px-64">
      <div className="flex items-center bg-white rounded-[10px] gap-3 p-4 justify-between my-8">
        <img
          className="h-[39px] w-[39px]"
          src={`${imageUrl}/searchpage/search.png`}
        />
        <input
          className="text-[25px] focus:outline-none focus:border-transparent w-[85%]"
          placeholder="Search"
        />
        <button className="font-bold text-[#5D462D] text-2xl">
          Reset filter
        </button>
      </div>
      <div className="flex justify-between mb-10">
        <div className="grid grid-cols-3 gap-8">
          <select className="leading-none text-5xl px-20  rounded-[30px] text-[#5D462D] font-normal text-center">
            <option>Nazar</option>
            <option>Loh</option>
          </select>
          <select className="leading-none text-5xl px-20 rounded-[30px] text-[#5D462D] font-normal text-center">
            <option>Nazar</option>
            <option>Loh</option>
          </select>
          <select className="leading-none text-5xl px-20 rounded-[30px] text-[#5D462D] font-normal text-center">
            <option>Nazar</option>
            <option>Loh</option>
          </select>
        </div>
        <button className="bg-[#967149] font-bold text-white text-4xl px-20 rounded-[30px]">
          Search
        </button>
      </div>
      <div>
        <h3 className="text-[25px] font-medium mb-1">
          Number of results: (12)
        </h3>
        <h4 className="text-[20px] mb-7">1 to 5 of 12:</h4>
      </div>
      <RestaurantCard />
      <RestaurantCard />
      <RestaurantCard />
      <RestaurantCard />
      <RestaurantCard />
      <RestaurantCard />
      <RestaurantCard />
    </div>
  );
};

export default SearchPage;
