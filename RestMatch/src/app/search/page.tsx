import RestaurantCard from "@/components/search-page/restaurant-card";
import { imageUrl } from "@/utils/constants";
import classes from "./page.module.scss";

const SearchPage = () => {
  return (
    <div className="bg-[#9F784E] flex flex-col w-full px-64">
      <div className="flex items-center bg-white rounded-[10px] gap-3 p-4 justify-between my-8 drop-shadow-lg">
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
          <div className={classes["custom-select"]}>
            <select>
              <option>Location</option>
            </select>
          </div>
          <div className={classes["custom-select"]}>
            <select>
              <option>Price</option>
            </select>
          </div>
          <div className={classes["custom-select"]}>
            <select>
              <option>Kind of food</option>
            </select>
          </div>
        </div>
        <button className="bg-[#967149] font-bold text-white text-5xl px-20 rounded-[30px]">
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
