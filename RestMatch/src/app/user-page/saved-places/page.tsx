'use client';

import SavedPlaceCard from "@/components/userpage/saved-places/saved-place-card";
import {useEffect, useState} from "react";
import {favouritesService} from "@/services/favourites.service";

const SavedPlaces = () => {
  const [data, setDate] = useState([]);

  const fetchFavourites = async () => {
    const response = await favouritesService.getFavourites();
    setDate(response.data);
  }

  useEffect(() => {
    fetchFavourites();
  }, []);

  return (
    <div className="w-full">
      <div className="w-full pt-16 px-7">
        <h1 className="px-[3.25rem] mb-5">My saved places</h1>
        <div className="grid grid-cols-3 gap-y-10">
          {data && data.map((item: any, index) => (
            <SavedPlaceCard key={index} title={item.restaurant.name} />
          ))}

        </div>
      </div>
    </div>
  );
};

export default SavedPlaces;
