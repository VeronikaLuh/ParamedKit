import {iconUrl} from "@/utils/constants";

interface IconProps {
  name: string;
  size?: number;
}

const Icon = (props: IconProps) => {
  const { name, size = 24 } = props;
  return (
    <img src={`${iconUrl}/${name}.svg`} width={size} height={24} alt="info"/>
  )
};

export default Icon;