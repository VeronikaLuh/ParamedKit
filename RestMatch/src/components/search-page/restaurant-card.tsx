import {imageUrl} from "@/utils/constants";
import React from "react";
import {Cuisine} from "@/models/Cuisines";
import {findRightCuisineType} from "@/utils/utils";
import {useRouter} from "next/navigation";
import {Routes} from "@/types/routes";

interface RestaurantCardProps {
  id: number;
  name: string;
  city: string;
  price: number;
  description: string;
  cuisinesTypes: Cuisine[];
  cuisineId: number;
  url?: string;
}

const RestaurantCard: React.FC<RestaurantCardProps> = (
  {
    id,
    url,
    name,
    city,
    description,
    price,
    cuisinesTypes,
    cuisineId
  }
) => {

  const router = useRouter();

  const handleClick = () => {
    router.push(`${Routes.INFO}/${id}`)
  }

  return (
    <div
      className="bg-[#8d6539] rounded-[10px] flex items-center mb-14 px-[31px] pt-[34px] pb-[24px] gap-4 drop-shadow-2xl min-w-[55.9rem]">
      <img
        className="rounded-lg w-[316px] h-[239px]"
        src={`${imageUrl}/searchpage/restourant-icon.jpg`}
        alt="Description of image"
      />
      <div className="flex flex-col self-start gap-1 text-white max-h-[239px] ml-4">
        <h3 className="leading-none text-[36px] font-normal">
          {name}
        </h3>
        <h3 className="text-[32px]">{city} • {price} ₴ • {findRightCuisineType(cuisinesTypes, cuisineId)}</h3>
        <p className="text-[20px] overflow-hidden">
          {description}
        </p>
      </div>
      <div className='ml-auto'>
        <button
          className="px-14 py-2 text-[25px] text-nowrap rounded-[30px] bg-[#CF914E] text-white font-bold"

          onClick={handleClick}>
          VIEW MORE
        </button>
      </div>
    </div>
  );
};

export default RestaurantCard;
