'use client';

import RestaurantCard from "@/components/search-page/restaurant-card";
import {imageUrl} from "@/utils/constants";
import classes from "./page.module.scss";
import restaurantService from "@/services/restaurant.service";
import {useEffect, useState} from "react";
import {Restaurant} from "@/models/Restaurant";
import {Cuisine} from "@/models/Cuisines";

const SearchPage = () => {
  const [data, setData] = useState<Restaurant[]>([]);
  const [cuisinesTypes, setCuisinesTypes] = useState<Cuisine[]>([]);

  const fetchRestaurants = async () => {
    const response = await restaurantService.getRestaurants();
    setData(response.data);
  }

  const fetchCuisines = async () => {
    const response = await restaurantService.getCuisines();
    setCuisinesTypes(response.data);
  }

  useEffect(() => {
    fetchRestaurants();
    fetchCuisines();
  }, []);


  return (
    <div className="bg-[#9F784E] flex flex-col w-full min-w-[55.9rem] max-w-[100rem] mx-auto">
      <div
        className="flex items-center bg-white rounded-[10px] gap-3 p-4 justify-between my-8 drop-shadow-lg min-w-[55.9rem]">
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
      <div className="flex justify-between mb-10 min-w-[55.9rem]">
        <div className="grid lg:grid-cols-8 gap-6 grid-cols-1">
          <div className={`${classes["custom-select"]} col-span-2`}>
            <select>
              <option>Location</option>
            </select>
          </div>
          <div className="flex items-center gap-4 col-span-3 text-center h-[3.625rem]">
            <h4>Price from</h4>
            <input className="border-2 border-gray-300 rounded-3xl min-w-2 h-full text-black px-4"/>
            <h4>Price to</h4>
            <input className="border-2 border-gray-300 rounded-3xl min-w-2 h-full text-black px-4"/>
          </div>
          <div className={`${classes["custom-select"]} col-span-2`}>
            <select>
              <option>Cuisine</option>
              <option>Mediterranean</option>
            </select>
          </div>
        </div>
        <button className="bg-[#967149] h-[3.625rem] text-[2.25rem] font-bold text-white text-5xl px-20 rounded-[30px]">
          Search
        </button>
      </div>
      <div>
        <h3 className="text-[25px] font-medium mb-1">
          Number of results: ({data.length})
        </h3>
        <h4 className="text-[20px] mb-7">1 to 5 of {data.length}:</h4>
      </div>
      {data.length > 0 && data.map((restaurant, index) => (
        <RestaurantCard
          key={index}
          name={restaurant.name}
          city={restaurant.city}
          price={restaurant.lowerPrice}
          description={restaurant.aboutText}
          cuisinesTypes={cuisinesTypes}
          cuisineId={restaurant.cuisines[0].typeId}
        />

      ))}
    </div>
  );
};

export default SearchPage;
